using Base.Domain.Consts;
using Base.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Infrastructure.Data.Configurations;
public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        var subjects = new List<Subject>
        {
            new Subject
            {
                Id = 1,
                Name = "aa",
                Samester = 1,
                Code = "1234",
                DoctorId = 1,
                LevelId = 1,
                DepartmentId = 1,
            }
        };

        //builder.HasData(subjects);
    }
}
