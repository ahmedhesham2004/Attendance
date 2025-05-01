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
            new Department
            {
                Id = 1,
                Name = "TIS",
            },
            new Department
            {
                Id = 2,
                Name = "BIS",
            },
            new Department
            {
                Id = 1,
                Name = "TIS",
            },
            new Department
            {
                Id = 1,
                Name = "TIS",
            },
            new Department
            {
                Id = 1,
                Name = "TIS",
            },
        };

        //builder.HasData(departments);
    }
}