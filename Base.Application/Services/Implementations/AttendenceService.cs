using Base.Application.Contracts.Attendences;
using Base.Application.Contracts.Students;
using Base.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;

namespace Base.Application.Services.Implementations;
public class AttendenceService(ApplicationDbContext context) : IAttendenceService
{
    private readonly ApplicationDbContext _context = context;
    public async Task<IEnumerable<AttendenceResponse>> GetAllAsync() =>
        await _context.Attendences
                .Include(x => x.Student)
                .ThenInclude(x => x.ApplicationUser)
                .Include(x => x.Subject)
                .ProjectToType<AttendenceResponse>()
                .AsNoTracking()
                .ToListAsync();

    public async Task SeedAsync()
    {
        if (!_context.Attendences.Any())
        {
            var students = await _context.Students.ToListAsync();
            var subjects = await _context.Subjects.ToListAsync();
            var attendences = new List<Attendence>();
            foreach (var student in students)
            {
                foreach (var subject in subjects)
                {
                    if (student.LevelId == subject.LevelId &&
                        student.DepartmentId == subject.DepartmentId)
                    {
                        attendences.Add(new Attendence
                        {
                            StudentId = student.Id,
                            SubjectId = subject.Id,
                            Count = 0
                        });
                    }
                }
            }

            _context.Attendences.AddRange(attendences);
            _context.SaveChanges();
        }
    }

}
