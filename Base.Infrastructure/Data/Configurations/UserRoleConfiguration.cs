using Base.Domain.Consts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Base.Infrastructure.Data.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        var userRole = new List<IdentityUserRole<string>>
        {
            new IdentityUserRole<string>
            {
                UserId = DefaultUser.AdminId,
                RoleId = DefaultRoles.Admin.Id
            },
        };

        builder.HasData(userRole);
    }
}
