using Base.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Infrastructure.Data.Configurations;
public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        var students = new List<Student>
        {
            new Student
            {
                Id = 1,
                ApplicationUserId = "683211b1-1125-42a1-b148-a606a4ca4df3",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 2,
                ApplicationUserId = "df2ea217-2e82-48b9-9442-47556c1a9403",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 3,
                ApplicationUserId = "6b9b3e85-ce32-4944-9a46-601bb2b40000",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 4,
                ApplicationUserId = "fc4df06f-05c2-4751-96c1-8040f2761b7f",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 5,
                ApplicationUserId = "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 6,
                ApplicationUserId = "ce47a5ab-df14-416a-b500-9b544fa666a4",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 7,
                ApplicationUserId = "249aa6c5-d578-4517-8a42-48f24a7d959e",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 8,
                ApplicationUserId = "49a438ba-672d-41d5-97ba-5536ffbec2a6",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 9,
                ApplicationUserId = "bf2ee728-59af-45ec-9b70-e5f5e27eef8e",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 10,
                ApplicationUserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df2",
                DepartmentId = 1,
                LevelId = 1
            },
            new Student
            {
                Id = 11,
                ApplicationUserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df3",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 12,
                ApplicationUserId = "5d577849-97d1-4984-bf96-6fee7d08c8be",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 13,
                ApplicationUserId = "f89bca4a-8fc9-4259-a46d-22562907c27f",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 14,
                ApplicationUserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df4",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 15,
                ApplicationUserId = "8766c317-1eaa-468a-b34d-59790c8eb915",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 16,
                ApplicationUserId = "a12bc34d-5e6f-7g8h-9i0j-1k2l3m4n5o6p",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 17,
                ApplicationUserId = "b23cd45e-6f7g-8h9i-0j1k-2l3m4n5o6p7q",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 18,
                ApplicationUserId = "c34de56f-7g8h-9i0j-1k2l-3m4n5o6p7q8r",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 19,
                ApplicationUserId = "d45ef67g-8h9i-0j1k-2l3m-4n5o6p7q8r9s",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 20,
                ApplicationUserId = "e56fg78h-9i0j-1k2l-3m4n-5o6p7q8r9s0t",
                DepartmentId = 2,
                LevelId = 1
            },
            new Student
            {
                Id = 21,
                ApplicationUserId = "f67gh89i-0j1k-2l3m-4n5o-6p7q8r9s0t1u",
                DepartmentId = 1,
                LevelId = 2
            },
            new Student
            {
                Id = 22,
                ApplicationUserId = "g78hi90j-1k2l-3m4n-5o6p-7q8r9s0t1u2v",
                DepartmentId = 1,
                LevelId = 2
            },
            new Student
            {
                Id = 23,
                ApplicationUserId = "h89ij01k-2l3m-4n5o-6p7q-8r9s0t1u2v3w",
                DepartmentId = 1,
                LevelId = 2
            },
            new Student
            {
                Id = 24,
                ApplicationUserId = "i90jk12l-3m4n-5o6p-7q8r-9s0t1u2v3w4x",
                DepartmentId = 1,
                LevelId = 2
            },
            new Student
            {
                Id = 25,
                ApplicationUserId = "j01kl23m-4n5o-6p7q-8r9s-0t1u2v3w4x5y",
                DepartmentId = 1,
                LevelId = 2
            },
            new Student
            {
                Id = 26,
                ApplicationUserId = "k12lm34n-5o6p-7q8r-9s0t-1u2v3w4x5y6z",
                DepartmentId = 1,
                LevelId = 2
            },
            new Student
            {
                Id = 27,
                ApplicationUserId = "l23mn45o-6p7q-8r9s-0t1u-2v3w4x5y6z7a",
                DepartmentId = 1,
                LevelId = 2
            },
            new Student
            {
                Id = 28,
                ApplicationUserId = "m34no56p-7q8r-9s0t-1u2v-3w4x5y6z7a8b",
                DepartmentId = 2,
                LevelId = 2
            },
            new Student
            {
                Id = 29,
                ApplicationUserId = "n45op67q-8r9s-0t1u-2v3w-4x5y6z7a8b9c",
                DepartmentId = 2,
                LevelId = 2
            },
            new Student
            {
                Id = 30,
                ApplicationUserId = "o56pq78r-9s0t-1u2v-3w4x-5y6z7a8b9c0d",
                DepartmentId = 2,
                LevelId = 2
            },
            new Student
            {
                Id = 31,
                ApplicationUserId = "p67qr89s-0t1u-2v3w-4x5y-6z7a8b9c0d1e",
                DepartmentId = 2,
                LevelId = 2
            },
            new Student
            {
                Id = 32,
                ApplicationUserId = "q78rs90t-1u2v-3w4x-5y6z-7a8b9c0d1e2f",
                DepartmentId = 2,
                LevelId = 2
            },
            new Student
            {
                Id = 33,
                ApplicationUserId = "r89st01u-2v3w-4x5y-6z7a-8b9c0d1e2f3g",
                DepartmentId = 2,
                LevelId = 2
            },
            new Student
            {
                Id = 34,
                ApplicationUserId = "s90tu12v-3w4x-5y6z-7a8b-9c0d1e2f3g4h",
                DepartmentId = 2,
                LevelId = 2
            },
            new Student
            {
                Id = 35,
                ApplicationUserId = "t01uv23w-4x5y-6z7a-8b9c-0d1e2f3g4h5i",
                DepartmentId = 2,
                LevelId = 2
            }

        };

        builder.HasData(students);
    }
}
