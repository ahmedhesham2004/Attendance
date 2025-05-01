using Base.Domain.Consts;
using Base.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Domain.Entities;

namespace Base.Infrastructure.Data.Configurations;
public class AttendenceConfigration : IEntityTypeConfiguration<Attendence>
{
    public void Configure(EntityTypeBuilder<Attendence> builder)
    {
        builder.HasKey(x => new { x.StudentId, x.SubjectId });

        var attendences = new List<Attendence>
        {
            new Attendence
            {
                Count = 0,
                StudentId = 1,
                SubjectId = 1
            }
        };

        //builder.HasData(attendences);
    }
}
