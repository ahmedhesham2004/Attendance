using Base.Application.Contracts.Roles;

namespace Base.Application.Services.Implementations;

public class RoleService(RoleManager<IdentityRole> _roleManager) : IRoleService
{
    public async Task<Result<IEnumerable<RoleResponse>>> GetAllAsync()
    {
        var roles = await _roleManager.Roles
            .ProjectToType<RoleResponse>()
            .AsNoTracking()
            .ToListAsync();

        return Result.Success<IEnumerable<RoleResponse>>(roles);
    }
}
