using Base.Application.Contracts.Department;
using Base.Application.Contracts.Levels;

namespace Base.Application.Services.Interfaces;
public interface IDepartmentService
{
    Task<Result<List<DepartmentResponse>>> GetAllAsync();
    Task<Result<DepartmentResponse>> GetAsync(int id);
}
