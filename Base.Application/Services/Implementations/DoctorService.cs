using Base.Application.Contracts.Doctor;
using Base.Application.Contracts.Nfc_Cards;
using Base.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Base.Domain.Consts.DefaultRoles;

namespace Base.Application.Services.Implementations;
public class DoctorService(ApplicationDbContext context, UserManager<ApplicationUser> _userManager) : IDoctorService
{
    private readonly ApplicationDbContext _Context = context;

    public async Task<Result<List<DoctorResponse>>> GetAllAsync()
    {
        var doctors =await _Context.Doctors.Include(x=>x.ApplicationUser).AsNoTracking().ProjectToType<DoctorResponse>().ToListAsync();
         
        return Result.Success(doctors);
    }

    public async Task<Result<DoctorResponse>> GetAsync(string userId)
    {
        var id = await _Context.Doctors.Where(x => x.ApplicationUserId == userId).Select(x => x.Id).FirstOrDefaultAsync();
        var doc = await _Context.Doctors.Where(x=>x.Id==id).Include(x => x.ApplicationUser).AsNoTracking().ProjectToType<DoctorResponse>().FirstOrDefaultAsync();
        return doc is null
           ? Result.Failure<DoctorResponse>(DoctorError.NotFound)
           : Result.Success(doc);
    }
    public async Task<Result<DoctorResponse>> CreateAsync(DoctorRequest request)
    {
        if (await _Context.Doctors.AnyAsync(x => x.ApplicationUserId == request.ApplicationUserId))
            return Result.Failure<DoctorResponse>(DoctorError.Dublicated);
        var doc = request.Adapt<Domain.Entities.Doctor>();

        var user = await _userManager.FindByIdAsync(request.ApplicationUserId);
        _userManager.AddToRoleAsync(user, "Doctor").Wait();

        await _Context.Doctors.AddAsync(doc);
        await _Context.SaveChangesAsync();

        return Result.Success(doc.Adapt<DoctorResponse>());
    }
    public async Task<Result> UpdateAsync(int id, DoctorRequest request)
    {
        if (await _Context.Doctors.FindAsync(id) is not { } doc)
            return Result.Failure<DoctorResponse>(DoctorError.NotFound);

        doc = request.Adapt(doc);
        await _Context.SaveChangesAsync();

        return Result.Success();

    }
    public async Task<Result> DeleteAsync(int id)
    {
        if (await _Context.Doctors.FindAsync(id) is not  { } doc)
            return Result.Failure<DoctorResponse>(DoctorError.NotFound);

        var user = await _userManager.FindByIdAsync(await _Context.Doctors.Where(x => x.Id == id).Select(x => x.ApplicationUserId).FirstAsync());
        _userManager.RemoveFromRoleAsync(user, "Doctor").Wait();

        _Context.Doctors.Remove(doc);
        await _Context.SaveChangesAsync();

        return Result.Success();
    }

}
