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
using static Base.Domain.Consts.DefaultRoles;
using System.Reflection.Emit;

namespace Base.Infrastructure.Data.Configurations;
public class AttendenceConfigration : IEntityTypeConfiguration<Attendence>
{

    public void Configure(EntityTypeBuilder<Attendence> builder)
    {
        builder.HasKey(x => x.Id);

        builder
        .HasOne(a => a.Student)
        .WithMany(s => s.Attendences)
        .HasForeignKey(a => a.StudentId)
        .OnDelete(DeleteBehavior.Cascade);

        builder
        .HasOne(a => a.Subject)
        .WithMany(s => s.Attendences)
        .HasForeignKey(a => a.SubjectId)
        .OnDelete(DeleteBehavior.Cascade);


    }
}
