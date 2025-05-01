using Base.Application.Contracts.Levels;

namespace Base.Application.Services.Implementations;
public class LevelService(ApplicationDbContext context) : ILevelService
{
    private readonly ApplicationDbContext _Context = context;

    public async Task<Result<List<LevelResponse>>> GetAllAsync()
    {
        return Result.Success(await _Context.Levels.AsNoTracking().ProjectToType<LevelResponse>().ToListAsync()) ;
    }

    public async Task<Result<List<LevelWithDepartments>>> GetAllWithDepartmentsAsync()
    {
        return Result.Success(await _Context.Levels.Include(x=>x.DepartmentLevels).AsNoTracking().ProjectToType<LevelWithDepartments>().ToListAsync());
    }

    public async Task<Result<List<LevelWithStudents>>> GetAllWithStudentsAsync()
    {
        return Result.Success(await _Context.Levels.Include(x=>x.Students).AsNoTracking().ProjectToType<LevelWithStudents>().ToListAsync());
    }

    public async Task<Result<List<LevelWithSubjects>>> GetAllWithSubjectsAsync()
    {
        return Result.Success(await _Context.Levels.Include(x => x.Subjects).AsNoTracking().ProjectToType<LevelWithSubjects>().ToListAsync());
    }

    public async Task<Result<LevelResponse>> GetAsync(int id)
    {
        var level=await _Context.Levels
            .Where(x=>x.Id==id)
            .ProjectToType<LevelResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return level is null
            ? Result.Failure<LevelResponse>(LevelError.NotFound)
            : Result.Success(level);
    }

    public async Task<Result<LevelWithDepartments>> GetWithDepartmentsAsync(int id)
    {
        var level = await _Context.Levels
            .Where(x => x.Id == id)
            .Include(x=>x.DepartmentLevels)
            .ProjectToType<LevelWithDepartments>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return level is null
            ? Result.Failure<LevelWithDepartments>(LevelError.NotFound)
            : Result.Success(level);
    }

    public async Task<Result<LevelWithStudents>> GetWithStudentsAsync(int id)
    {
        var level = await _Context.Levels
            .Where(x => x.Id == id)
            .Include(x=>x.Students)
            .ProjectToType<LevelWithStudents>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return level is null
            ? Result.Failure<LevelWithStudents>(LevelError.NotFound)
            : Result.Success(level);
    }

    public async Task<Result<LevelWithSubjects>> GetWithSubjectsAsync(int id)
    {
        var level = await _Context.Levels
            .Where(x => x.Id == id)
            .Include(x => x.Subjects)
            .ProjectToType<LevelWithSubjects>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return level is null
            ? Result.Failure<LevelWithSubjects>(LevelError.NotFound)
            : Result.Success(level);
    }
}
