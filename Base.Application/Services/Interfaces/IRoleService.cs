using Base.Application.Contracts.Roles;

namespace Base.Application.Services.Interfaces;

public interface IRoleService
{
    Task<Result<IEnumerable<RoleResponse>>> GetAllAsync();
}
