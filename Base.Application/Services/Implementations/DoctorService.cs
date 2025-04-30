using Base.Application.Contracts.Doctor;
using Base.Application.Contracts.Nfc_Cards;
using Base.Domain.Entities;

namespace Base.Application.Services.Implementations;
public class DoctorService(ApplicationDbContext context) : IDoctorService
{
    private readonly ApplicationDbContext _Context = context;

    public async Task<Result<List<DoctorResponse>>> GetAllAsync()
    {
        var doctors =await _Context.Doctors.Include(x=>x.ApplicationUser).AsNoTracking().ProjectToType<DoctorResponse>().ToListAsync();
         
        return Result.Success(doctors);
    }

    public async Task<Result<DoctorResponse>> GetAsync(int id)
    {
        var doc = await _Context.Doctors.Where(x=>x.Id==id).Include(x => x.ApplicationUser).AsNoTracking().ProjectToType<DoctorResponse>().FirstOrDefaultAsync();
        return doc is null
           ? Result.Failure<DoctorResponse>(DoctorError.NotFound)
           : Result.Success(doc);
    }
    public async Task<Result<DoctorResponse>> CreateAsync(DoctorRequest request)
    {
        if (await _Context.Doctors.AnyAsync(x => x.ApplicationUserId == request.ApplicationUserId))
            return Result.Failure<DoctorResponse>(DoctorError.Dublicated);
        var doc = request.Adapt<Doctor>();

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

        _Context.Doctors.Remove(doc);
        await _Context.SaveChangesAsync();

        return Result.Success();
    }

}
