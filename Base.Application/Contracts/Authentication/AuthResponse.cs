namespace Base.Application.Contracts.Authentication;
public record AuthResponse(
    string Id,
    string Email,
    string FirstName,
    string LastName,
    string Token,
    int ExpiresIn
);

public record AuthWhithOutTokenAndExpiresInResponse(
    string Id,
    string Email,
    string FirstName,
    string LastName
);
