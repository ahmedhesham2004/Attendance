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
                ApplicationUserId = "Aa",
                DepartmentId = 1,
                LevelId = 1
            }
        };

        //builder.HasData(students);
    }
}
