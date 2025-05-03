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
            // level 1 dep 1 sem 1
            new Subject
            {
                Id = 1,
                Name = "مبادئ اقتصاد 1",
                Samester = 1,
                Code = "E3576909",
                DoctorId = 1,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 2,
                Name = "حزم تطبيقات مكتبيه",
                Samester = 1,
                Code = "2",
                DoctorId = 2,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 3,
                Name = "مبادئ محاسبه 1",
                Samester = 1,
                Code = "3",
                DoctorId = 3,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 4,
                Name = "لغة إنجليزية 1",
                Samester = 1,
                Code = "4",
                DoctorId = 4,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 5,
                Name = "مقدمه في الحاسب",
                Samester = 1,
                Code = "5",
                DoctorId = 5,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 6,
                Name = "مبادئ الاداره",
                Samester = 1,
                Code = "6",
                DoctorId = 6,
                LevelId = 1,
                DepartmentId = 1,
            },
            // level 1 dep 1 sem 2
            new Subject
            {
                Id = 7,
                Name = "مبادئ البرمجة للأعمال",
                Samester = 2,
                Code = "7",
                DoctorId = 7,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 8,
                Name = "اقتصاد 2",
                Samester = 2,
                Code = "8",
                DoctorId = 8,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 9,
                Name = "السلوك التنظيمي",
                Samester = 2,
                Code = "9",
                DoctorId = 9,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 10,
                Name = "مبادئ محاسبه 2",
                Samester = 2,
                Code = "10",
                DoctorId = 10,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 11,
                Name = "مبادئ احصاء",
                Samester = 2,
                Code = "11",
                DoctorId = 11,
                LevelId = 1,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 12,
                Name = "أساسيات نظم المعلومات",
                Samester = 2,
                Code = "12",
                DoctorId = 12,
                LevelId = 1,
                DepartmentId = 1,
            },
            // level 1 dep 2 sem 1
            new Subject
            {
                Id = 13,
                Name = "أساسيات تكنولوجيا المعلومات",
                Samester = 1,
                Code = "13",
                DoctorId = 13,
                LevelId = 1,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 14,
                Name = "مقدمه في البرمجه",
                Samester = 1,
                Code = "14",
                DoctorId = 14,
                LevelId = 1,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 15,
                Name = "حزم تطبيقات مكتبيه",
                Samester = 1,
                Code = "15",
                DoctorId = 15,
                LevelId = 1,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 16,
                Name = "مقدمة في الحاسبات",
                Samester = 1,
                Code = "16",
                DoctorId = 1,
                LevelId = 1,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 17,
                Name = "الرياضيات المنفصلة",
                Samester = 1,
                Code = "17",
                DoctorId = 2,
                LevelId = 1,
                DepartmentId = 2,
            },
            // level 1 dep 2 sem 2
            new Subject
            {
                Id = 18,
                Name = "تفاضل وتكامل",
                Samester = 2,
                Code = "18",
                DoctorId = 3,
                LevelId = 1,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 19,
                Name = "رياضيات الحاسب",
                Samester = 2,
                Code = "19",
                DoctorId = 4,
                LevelId = 1,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 20,
                Name = "أسس التفكير النقدي والعلمي",
                Samester = 2,
                Code = "20",
                DoctorId = 5,
                LevelId = 1,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 21,
                Name = "برمجه الحاسب 1",
                Samester = 2,
                Code = "21",
                DoctorId = 6,
                LevelId = 1,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 22,
                Name = "احتمالات وإحصاء",
                Samester = 2,
                Code = "22",
                DoctorId = 7,
                LevelId = 1,
                DepartmentId = 2,
            },
            /////////////////////////////////////////////////////////////
            // level 2 dep 1 sem 1
            new Subject
            {
                Id = 23,
                Name = "نظم التشغيل",
                Samester = 1,
                Code = "23",
                DoctorId = 8,
                LevelId = 2,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 24,
                Name = "مبادئ التسويق",
                Samester = 1,
                Code = "24",
                DoctorId = 9,
                LevelId = 2,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 25,
                Name = "علم الجوده",
                Samester = 1,
                Code = "25",
                DoctorId = 10,
                LevelId = 2,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 26,
                Name = "محاسبة متوسطة",
                Samester = 1,
                Code = "26",
                DoctorId = 11,
                LevelId = 2,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 27,
                Name = "نقود وبنوك",
                Samester = 1,
                Code = "27",
                DoctorId = 12,
                LevelId = 2,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 28,
                Name = "إحصاء تطبيقي",
                Samester = 1,
                Code = "28",
                DoctorId = 13,
                LevelId = 2,
                DepartmentId = 1,
            },
            // level 2 dep 1 sem 2
            new Subject
            {
                Id = 29,
                Name = "تطبيقات الانترنت",
                Samester = 2,
                Code = "29",
                DoctorId = 14,
                LevelId = 2,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 30,
                Name = "التجاره الالكترونيه",
                Samester = 2,
                Code = "30",
                DoctorId = 15,
                LevelId = 2,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 31,
                Name = "لغات البرمجه للأعمال 1",
                Samester = 2,
                Code = "31",
                DoctorId = 1,
                LevelId = 2,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 32,
                Name = "نظم معلومات الأعمال",
                Samester = 2,
                Code = "32",
                DoctorId = 2,
                LevelId = 2,
                DepartmentId = 1,
            },
            new Subject
            {
                Id = 33,
                Name = "محاسبه متوسطه 2",
                Samester = 2,
                Code = "33",
                DoctorId = 3,
                LevelId = 2,
                DepartmentId = 1,
            },
            // level 2 dep 2 sem 1
            new Subject
            {
                Id = 34,
                Name = "نظم التشغيل",
                Samester = 1,
                Code = "34",
                DoctorId = 4,
                LevelId = 2,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 35,
                Name = "مبادئ التسويق",
                Samester = 1,
                Code = "35",
                DoctorId = 5,
                LevelId = 2,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 36,
                Name = "محاسبة متوسطة",
                Samester = 1,
                Code = "36",
                DoctorId = 6,
                LevelId = 2,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 37,
                Name = "شبكات الحاسب 1",
                Samester = 1,
                Code = "37",
                DoctorId = 7,
                LevelId = 2,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 38,
                Name = "مقدمة في علم البيانات",
                Samester = 1,
                Code = "38",
                DoctorId = 8,
                LevelId = 2,
                DepartmentId = 2,
            },
            // level 2 dep 2 sem 2
            new Subject
            {
                Id = 39,
                Name = "تطبيقات الانترنت",
                Samester = 2,
                Code = "39",
                DoctorId = 9,
                LevelId = 2,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 40,
                Name = "تطبيقات في الأمن السيبراني",
                Samester = 2,
                Code = "40",
                DoctorId = 10,
                LevelId = 2,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 41,
                Name = "تكنولوجيا الوسائط المتعدده ",
                Samester = 2,
                Code = "41",
                DoctorId = 11,
                LevelId = 2,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 42,
                Name = "نظم معلومات الأعمال",
                Samester = 2,
                Code = "42",
                DoctorId = 12,
                LevelId = 2,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 43,
                Name = "تطبيقات الخوارزميات",
                Samester = 2,
                Code = "43",
                DoctorId = 13,
                LevelId = 2,
                DepartmentId = 2,
            },
            new Subject
            {
                Id = 44,
                Name = "برمجه الحاسب 2",
                Samester = 2,
                Code = "44",
                DoctorId = 14,
                LevelId = 2,
                DepartmentId = 2,
            },
            /////////////////////////////////////////////////////////////

        };

        builder.HasData(subjects);
    }
}
