using Base.Domain.Consts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Base.Infrastructure.Data.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData([
            new IdentityRole(){
                Id = DefaultRoles.Admin.Id,
                Name = DefaultRoles.Admin.Name,
                NormalizedName = DefaultRoles.Admin.Name.ToUpper(),
                ConcurrencyStamp = DefaultRoles.Admin.ConcurrencyStamp,
            },
            new IdentityRole(){
                Id = DefaultRoles.User.Id,
                Name = DefaultRoles.User.Name,
                NormalizedName = DefaultRoles.User.Name.ToUpper(),
                ConcurrencyStamp = DefaultRoles.User.ConcurrencyStamp,
            }
        ]);
    }
}
