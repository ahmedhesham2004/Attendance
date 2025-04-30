using Base.Application.Contracts.Nfc_Cards;
using Base.Application.Contracts.Users;

namespace Base.Application.Contracts.Students;

public class StudentResponse
{
    public int Id { get; set; }
    public UserProfileResponse ApplicationUser { get; set; }
    public Nfc_CardResponse? nfc { get; set; }
    public StudentDepartmentResponse Department { get; set; }
    public StudentLevelResponse Level { get; set; }
    public ICollection<Attendence> Attendences { get; set; }
}
