using Base.Application.Contracts.Attendences;
using Base.Application.Contracts.Department;
using Base.Application.Contracts.Levels;
using Base.Application.Contracts.Nfc_Cards;
using Base.Application.Contracts.Students;
using Base.Application.Contracts.Subjects;
using Base.Application.Contracts.Users;

namespace Base.Application.Mapping;

public class MappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, ApplicationUser>()
            .Map(des => des.UserName, src => src.Email);

        config.NewConfig<CreateUserRequest, ApplicationUser>()
            .Map(des => des.UserName, src => src.Email);

        config.NewConfig<Nfc_CardRequest, NFC_Card>()
         .Ignore(dest=>dest.ImageUrl);

        config.NewConfig<Student, StudentResponse>()
          .Map(des => des.nfc, src => src.NFC_Card ?? null); 
        
        config.NewConfig<Attendence, AttendenceResponse>()
          .Map(des => des.Count, src => src.Count)
          .Map(des => des.SubjectName, src => src.Subject.Name)
          .Map(des => des.StudentName, src => src.Student.ApplicationUser.FirstName+' '+src.Student.ApplicationUser.LastName);

        config.NewConfig<Level, LevelWithDepartments>()
            .Map(des => des.Departments, src => src.DepartmentLevels.Select(x=>x.Department));

        config.NewConfig<Level, LevelWithStudents>()
            .Map(des => des.StudentsName, src => src.Students.Select(x => $"{x.ApplicationUser.FirstName} {x.ApplicationUser.LastName}"));

        config.NewConfig<Level, LevelWithSubjects>()
            .Map(des => des.SubjectsName, src => src.Subjects.Select(x => $"{x.Name}"));

        config.NewConfig<Department, DepartmentResponse>()
          .Map(des => des.StudentsName, src => src.Students.Select(x => $"{x.ApplicationUser.FirstName} {x.ApplicationUser.LastName}"))
          .Map(des => des.SubjectsName, src => src.Subjects.Select(x => x.Name));

        config.NewConfig<Subject, SubjectResponse>()
          .Map(des => des.LevelName, src => src.Level.Name)
          .Map(des => des.DepartmentName, src => src.Department.Name)
          .Map(des => des.DoctorName, src => src.Doctor.ApplicationUser.FirstName + ' ' + src.Doctor.ApplicationUser.LastName);

    }
}