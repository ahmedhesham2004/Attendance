using Microsoft.AspNetCore.Identity;

namespace Base.Domain.Entities.Identity;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Sex { get; set; } = null!;
    public string? NationalId { get; set; }
    public string ImageUrl { get; set; } = null!;

    public ICollection<Student> Students { get; set; }
    public ICollection<Doctor> Doctors { get; set; }

}
