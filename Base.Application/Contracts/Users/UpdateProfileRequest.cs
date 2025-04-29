namespace Base.Application.Contracts.Users;

public class UpdateProfileRequest
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Sex { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string NationalId { get; set; } = null!;
}
