namespace Base.Application.Contracts.Authentication;


public record ConfirmEmailRequest(
    string UserId,
    string Code
);
