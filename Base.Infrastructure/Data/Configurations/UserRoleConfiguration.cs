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
            new IdentityUserRole<string>
            {
                UserId = "10eb7637-95f4-45d2-b200-84dbb188ec41", 
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "a0e2f1e7-53e5-416f-b0b0-ca4668563233", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "52511e3a-0690-45b0-9e52-02667a473b18", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "52511e3a-0690-45b0-9e52-02667a473c23", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "u12vw34x-5y6z-7a8b-9c0d-1e2f3g4h5i6j", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "v23wx45y-6z7a-8b9c-0d1e-2f3g4h5i6j7k", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "w34xy56z-7a8b-9c0d-1e2f-3g4h5i6j7k8l", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "x45yz67a-8b9c-0d1e-2f3g-4h5i6j7k8l9m", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "y56za78b-9c0d-1e2f-3g4h-5i6j7k8l9m0n", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "z67ab89c-0d1e-2f3g-4h5i-6j7k8l9m0n1o", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "a78bc90d-1e2f-3g4h-5i6j-7k8l9m0n1o2p", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "b89cd01e-2f3g-4h5i-6j7k-8l9m0n1o2p3q", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "c90de12f-3g4h-5i6j-7k8l-9m0n1o2p3q4r", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "d01ef23g-4h5i-6j7k-8l9m-0n1o2p3q4r5s", // بدل DefaultUser.AdminId
                RoleId = DefaultRoles.Doctor.Id
            }

        };

        builder.HasData(userRole);
    }
}
