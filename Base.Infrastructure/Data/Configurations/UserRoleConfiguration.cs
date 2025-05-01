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
            },
            new IdentityUserRole<string>
            {
                UserId = "683211b1-1125-42a1-b148-a606a4ca4df3",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "df2ea217-2e82-48b9-9442-47556c1a9403",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "6b9b3e85-ce32-4944-9a46-601bb2b40000",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "fc4df06f-05c2-4751-96c1-8040f2761b7f",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "ce47a5ab-df14-416a-b500-9b544fa666a4",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "249aa6c5-d578-4517-8a42-48f24a7d959e",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "49a438ba-672d-41d5-97ba-5536ffbec2a6",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "bf2ee728-59af-45ec-9b70-e5f5e27eef8e",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df2",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df3",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "5d577849-97d1-4984-bf96-6fee7d08c8be",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "f89bca4a-8fc9-4259-a46d-22562907c27f",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df4",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "8766c317-1eaa-468a-b34d-59790c8eb915",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "a12bc34d-5e6f-7g8h-9i0j-1k2l3m4n5o6p",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "b23cd45e-6f7g-8h9i-0j1k-2l3m4n5o6p7q",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "c34de56f-7g8h-9i0j-1k2l-3m4n5o6p7q8r",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "d45ef67g-8h9i-0j1k-2l3m-4n5o6p7q8r9s",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "e56fg78h-9i0j-1k2l-3m4n-5o6p7q8r9s0t",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "f67gh89i-0j1k-2l3m-4n5o-6p7q8r9s0t1u",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "g78hi90j-1k2l-3m4n-5o6p-7q8r9s0t1u2v",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "h89ij01k-2l3m-4n5o-6p7q-8r9s0t1u2v3w",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "i90jk12l-3m4n-5o6p-7q8r-9s0t1u2v3w4x",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "j01kl23m-4n5o-6p7q-8r9s-0t1u2v3w4x5y",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "k12lm34n-5o6p-7q8r-9s0t-1u2v3w4x5y6z",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "l23mn45o-6p7q-8r9s-0t1u-2v3w4x5y6z7a",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "m34no56p-7q8r-9s0t-1u2v-3w4x5y6z7a8b",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "n45op67q-8r9s-0t1u-2v3w-4x5y6z7a8b9c",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "o56pq78r-9s0t-1u2v-3w4x-5y6z7a8b9c0d",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "p67qr89s-0t1u-2v3w-4x5y-6z7a8b9c0d1e",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "q78rs90t-1u2v-3w4x-5y6z-7a8b9c0d1e2f",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "r89st01u-2v3w-4x5y-6z7a-8b9c0d1e2f3g",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "s90tu12v-3w4x-5y6z-7a8b-9c0d1e2f3g4h",
                RoleId = DefaultRoles.Student.Id
            },
            new IdentityUserRole<string>
            {
                UserId = "t01uv23w-4x5y-6z7a-8b9c-0d1e2f3g4h5i",
                RoleId = DefaultRoles.Student.Id
            }


        };

        builder.HasData(userRole);
    }
}
