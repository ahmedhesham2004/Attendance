namespace Base.Application.Contracts.Users;

public record CreateUserRequest(
    string FirstName,
    string LastName,
    string Email,
    string NationalId,
    string PhoneNumber,
    string Sex,
    string Password,
    IList<string> Roles
);
