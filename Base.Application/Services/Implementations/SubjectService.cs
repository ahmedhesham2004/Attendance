using Base.Application.Contracts.Doctor;
using Base.Application.Contracts.Subjects;

namespace Base.Application.Services.Implementations;
public class SubjectService(ApplicationDbContext context) : ISubjectService
{
    private readonly ApplicationDbContext _Context = context;

    public async Task<Result<List<SubjectResponse>>> GetAllAsync()
    {
        var subjects = await _Context.Subjects.Include(x=>x.Attendences).AsNoTracking().ProjectToType<SubjectResponse>().ToListAsync();

        return Result.Success(subjects);
    }

    public async Task<Result<SubjectResponse>> GetAsync(int id)
    {
        var subject = await _Context.Subjects
            .Where(x => x.Id == id)
            .Include(x => x.Attendences)
            .AsNoTracking()
            .ProjectToType<SubjectResponse>()
            .FirstOrDefaultAsync();

        return subject is null
           ? Result.Failure<SubjectResponse>(SubjectError.NotFound)
           : Result.Success(subject);
    }
    public async Task<Result<SubjectResponse2>> CreateAsync(SubjectRequest request)
    {
        if (await _Context.Subjects.AnyAsync(x => x.Name == request.Name))
            return Result.Failure<SubjectResponse2>(SubjectError.Duplicated);

        if(!await _Context.Doctors.AnyAsync(x=>x.Id ==request.DoctorId))
            return Result.Failure<SubjectResponse2>(DoctorError.NotFound);

        if (!await _Context.Levels.AnyAsync(x => x.Id == request.LevelId))
            return Result.Failure<SubjectResponse2>(LevelError.NotFound);

        if (!await _Context.Departments.AnyAsync(x => x.Id == request.DepartmentId))
            return Result.Failure<SubjectResponse2>(DepartmentError.NotFound);

        var subject = request.Adapt<Subject>();

        await _Context.Subjects.AddAsync(subject);
        await _Context.SaveChangesAsync();

        return Result.Success(subject.Adapt<SubjectResponse2>());
    }

    public async Task<Result> UpdateAsync(int id, SubjectRequest request)
    {
        if (await _Context.Subjects.FindAsync(id) is not { } subject)
            return Result.Failure<DoctorResponse>(DoctorError.NotFound);

        if (await _Context.Subjects.AnyAsync(x => x.Name == request.Name))
            return Result.Failure<SubjectResponse>(SubjectError.Duplicated);

        subject = request.Adapt(subject);
        await _Context.SaveChangesAsync();

        return Result.Success();
    }
    public async Task<Result> DeleteAsync(int id)
    {
        if (await _Context.Subjects.FindAsync(id) is not { } subject)
            return Result.Failure<DoctorResponse>(DoctorError.NotFound);

        _Context.Subjects.Remove(subject);
        await _Context.SaveChangesAsync();

        return Result.Success();
    }
}
