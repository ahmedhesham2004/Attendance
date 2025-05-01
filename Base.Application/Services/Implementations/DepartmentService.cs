using Base.Application.Contracts.Department;
using Base.Application.Contracts.Levels;

namespace Base.Application.Services.Implementations;
public class DepartmentService(ApplicationDbContext context) : IDepartmentService
{
    private readonly ApplicationDbContext _Context = context;

    public async Task<Result<List<DepartmentResponse>>> GetAllAsync()
    {
        var departments = await _Context.Departments
            .Include(x => x.Students)
            .Include(x => x.Subjects)
            .AsNoTracking()
            .ProjectToType<DepartmentResponse>()
            .ToListAsync();
        return Result.Success(departments);
    }

    public async Task<Result<DepartmentResponse>> GetAsync(int id)
    {
        var level = await _Context.Departments
            .Where(x => x.Id == id)
            .Include(x => x.Students)
            .Include(x => x.Subjects)
            .AsNoTracking()
            .ProjectToType<DepartmentResponse>()
            .FirstOrDefaultAsync();

        return level is null
            ? Result.Failure<DepartmentResponse>(DepartmentError.NotFound)
            : Result.Success(level);
    }
}
