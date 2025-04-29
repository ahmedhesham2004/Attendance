namespace Base.Application.Contracts.Users;

//public record UserProfileResponse(
//    string FirstName,
//    string LastName,
//    string Sex,
//    string Email,
//    string PhoneNumber,
//    string NationalId,
//    string ImageUrl,
//    string UserName,
//    IList<string> Role
//);

public record UserProfileResponse
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Sex { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string NationalId { get; set; }
    public string ImageUrl { get; set; }
    public string UserName { get; set; }
    public IList<string> Role { get; set; }
}
