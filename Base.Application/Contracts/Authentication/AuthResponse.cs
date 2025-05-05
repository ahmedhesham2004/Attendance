namespace Base.Application.Contracts.Authentication;
public record AuthResponse(
    string Id,
    string Email,
    string FirstName,
    string LastName,
    string Token,
    int ExpiresIn,
    IEnumerable<string> Roles
);

public record AuthWhithOutTokenAndExpiresInResponse(
    string Id,
    string Email,
    string FirstName,
    string LastName
);
