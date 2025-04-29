using System.ComponentModel.DataAnnotations;

namespace Base.Application.Contracts.Authentication;

public record ResendConfirmationEmailRequest(
    [EmailAddress] string Email
);
