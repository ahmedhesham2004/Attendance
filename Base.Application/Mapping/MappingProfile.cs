using Base.Application.Contracts.Attendences;
using Base.Application.Contracts.Nfc_Cards;
using Base.Application.Contracts.Students;
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
    }
}
