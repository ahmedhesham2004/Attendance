﻿using Base.Application.Contracts.Students;
using static Base.Domain.Consts.DefaultRoles;
using Student = Base.Domain.Entities.Student;

namespace Base.Application.Services.Implementations;
public class StudentService(ApplicationDbContext context, UserManager<ApplicationUser> _userManager) : IStudentService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<AddStudentResponse>> AddAsync(StudentRequest request)
    {
        var isExstingUserId = await _context.ApplicationUsers.AnyAsync(x => x.Id == request.ApplicationUserId);
        if (!isExstingUserId)
            return Result.Failure<AddStudentResponse>(UserErrors.UserNotFound);

        var isExstingLevelId = await _context.Levels.AnyAsync(x => x.Id == request.LevelId);
        if (!isExstingLevelId)
            return Result.Failure<AddStudentResponse>(LevelError.NotFound);

        var isExstingDepartmentId = await _context.Departments.AnyAsync(x => x.Id == request.DepartmentId);
        if (!isExstingDepartmentId)
            return Result.Failure<AddStudentResponse>(DepartmentError.NotFound);

        var UserIdUsed = await _context.Students.AnyAsync(x => x.ApplicationUserId == request.ApplicationUserId);
        if (UserIdUsed)
            return Result.Failure<AddStudentResponse>(StudentErrors.DublicatedUserId);

        var student = request.Adapt<Student>();

        var user = await _userManager.FindByIdAsync(request.ApplicationUserId);
        _userManager.AddToRoleAsync(user, "Student").Wait();

        await _context.AddAsync(student);
        await _context.SaveChangesAsync();

        var subjects = await _context.Subjects.ToListAsync();
        var attendences = new List<Attendence>();
        
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

        await _context.Attendences.AddRangeAsync(attendences);
        await _context.SaveChangesAsync();


        return Result.Success(student.Adapt<AddStudentResponse>());
    }
    public async Task<IEnumerable<StudentResponse>> GetAllAsync() =>
        await _context.Students
                .Include(x => x.ApplicationUser)
                .Include(x => x.Level)
                .Include(x => x.Department)
                .Include(x => x.NFC_Card)
                .Include(x => x.Attendences)
                .ProjectToType<StudentResponse>()
                .AsNoTracking()
                .ToListAsync();
    public async Task<Result<StudentResponse>> GetAsync(string userId)
    {
        var studentId = await _context.Students
            .Where(x => x.ApplicationUserId == userId)
            .Select(x => x.Id)
            .FirstOrDefaultAsync();

        var student = await _context.Students
            .Where(x => x.Id == studentId)
            .Include(x => x.ApplicationUser)
            .Include(x => x.Level)
            .Include(x => x.Department)
            .Include(x => x.NFC_Card)
            .Include(x => x.Attendences)
            .ProjectToType<StudentResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (student is not null)
        {
            var role = await _userManager.GetRolesAsync(await _context.ApplicationUsers.Where(x => x.Id == userId).FirstAsync());
            student.ApplicationUser.Roles = role;
        }  

        return student is null ? Result.Failure<StudentResponse>(StudentErrors.StudentNotFound) : Result.Success(student);
    }
    public async Task<Result> DeleteAsync(int studentId)
    {
        var isExstingStudent = await _context.Students.AnyAsync(x => x.Id == studentId);
        if (!isExstingStudent)
            return Result.Failure(StudentErrors.StudentNotFound);


        var user = await _userManager.FindByIdAsync(await _context.Students.Where(x => x.Id == studentId).Select(x => x.ApplicationUserId).FirstAsync());
        _userManager.RemoveFromRoleAsync(user, "Student").Wait();

        _context.Students.Remove(new Student { Id = studentId });
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}