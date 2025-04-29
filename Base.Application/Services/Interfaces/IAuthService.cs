﻿namespace Base.Application.Services.Interfaces;
public interface IAuthService
{
    Task<Result<AuthResponse>> GetTokenAsync(LoginRequest request);
    Task<Result<string>> RegisterAsync(RegisterRequest request);
    Task<Result<string>> ConfirmEmailAsync(ConfirmEmailRequest request);
    Task<Result<string>> ResendConfirmationEmailAsync(ResendConfirmationEmailRequest request);
    Task<Result<string>> SendResetPasswordCodeAsync(string email);
    Task<Result<string>> ResetPasswordAsync(ResetPasswordRequest request);
}
