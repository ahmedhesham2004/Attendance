using Base.Application.Contracts.Levels;

namespace Base.Application.Services.Implementations;
public class LevelService(ApplicationDbContext context) : ILevelService
{
    private readonly ApplicationDbContext _Context = context;

    public async Task<Result<List<LevelResponse>>> GetAllAsync()
    {
        return Result.Success(await _Context.Levels.Include(x => x.Students).AsNoTracking().ProjectToType<LevelResponse>().ToListAsync()) ;
    }

    public async Task<Result<LevelResponse>> GetAsync(int id)
    {
        var level=await _Context.Levels
            .Where(x=>x.Id==id)
            .Include(x=>x.Students)
            .ProjectToType<LevelResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return level is null
            ? Result.Failure<LevelResponse>(LevelError.NotFound)
            : Result.Success(level);
    }
}
