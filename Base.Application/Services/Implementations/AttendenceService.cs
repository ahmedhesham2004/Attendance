using Base.Application.Contracts.Attendences;
using Base.Application.Contracts.Students;
using Base.Domain.Entities;
using Microsoft.AspNetCore.Identity;

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

}
