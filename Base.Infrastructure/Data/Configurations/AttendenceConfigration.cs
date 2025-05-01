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
public class AttendenceConfigration(ApplicationDbContext context) : IEntityTypeConfiguration<Attendence>
{
    private readonly ApplicationDbContext _context = context;

    public void Configure(EntityTypeBuilder<Attendence> builder)
    {
        builder.HasKey(x => x.Id);
       
        var students = _context.Students.ToList();
        var subjects = _context.Subjects.ToList();

        //var attendences = new List<Attendence>();

        //var z = 1;
        //foreach (var student in students)
        //{
        //    foreach (var subject in subjects)
        //    {
        //        var x = student.LevelId;
        //        var x2 = subject.LevelId;
        //        var y = student.DepartmentId;
        //        var y2 = subject.DepartmentId;
        //        if (x == x2 && y == y2)
        //        {
        //            attendences.Add(new Attendence
        //            {
        //                Id = z++,
        //                StudentId = student.Id,
        //                SubjectId = subject.Id,
        //                Count = 0 // يمكن تغيير القيمة حسب الحاجة
        //            });
        //        } 
        //    }
        //};

        //builder.HasData(attendences);
    }
}
