using Base.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Infrastructure.Data.Configurations;
public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        var departments = new List<Department>
        {
            new Department //1 2
            {
                Id = 1,
                Name = "شعبه عامه",
            },
            new Department // 1 2 3 4
            {
                Id = 2,
                Name = "ادارة نظم تكنولوجيا المعلومات",
            },
            new Department // 3 4 1 2
            {
                Id = 3,
                Name = "نظم معلومات الأعمال",
            },
            new Department // 3 4 1 2
            {
                Id = 4,
                Name = "تكنولوجيا الادارة والاعمال",
            },
            new Department //1 2 3 4
            {
                Id = 5,
                Name = "تكنولوجيا المحاسبة",
            }
        };

        builder.HasData(departments);
    }
}