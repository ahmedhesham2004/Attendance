using System.ComponentModel.DataAnnotations;

namespace Base.Application.Contracts.Authentication;

public record ForgetPasswordRequest(
    [EmailAddress] string Email
);
