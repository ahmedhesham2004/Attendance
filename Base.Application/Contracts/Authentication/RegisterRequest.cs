namespace Base.Application.Contracts.Authentication;


public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string NationalId,
    string PhoneNumber,
    string Sex,
    string Password,
    string ConfirmPassword
);
