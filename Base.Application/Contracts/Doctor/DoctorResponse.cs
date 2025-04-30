using Base.Application.Contracts.Users;

namespace Base.Application.Contracts.Doctor;
public class DoctorResponse
{
    public int Id { get; set; }

    public UserResponse ApplicationUser { get; set; } = null!;

    public List<Subject> Subjects { get; set; }
}
