using Base.Application.Contracts.Levels;
using Base.Application.Contracts.Nfc_Cards;
using Base.Application.Contracts.Users;

namespace Base.Application.Contracts.Students;
public record StudentResponse
(
    int Id,
    UserProfileResponse ApplicationUser,
    Nfc_CardResponse? nfc,
    StudentDepartmentResponse Department,
    StudentLevelResponse Level,
    ICollection<Attendence> Attendences
);
