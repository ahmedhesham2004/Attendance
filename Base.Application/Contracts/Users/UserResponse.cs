using Base.Application.Contracts.Nationality;

namespace Base.Application.Contracts.Users;

public class UserResponse
{
    public string Id { get; init; } = null!;
    public string FirstName { get; init; } = null!;
    public string LastName { get; init; } = null!;
    public string Email { get; init; } = null!;
    public string PhoneNumber { get; init; } = null!;
    public string? NationalId { get; init; }
    public IEnumerable<string> Roles { get; set; } = [];
}

public record TouGuideUserResponse
(
     string FirstName,
     string LastName,
     string Email,
     string ImageUrl,
     string Sex
);
