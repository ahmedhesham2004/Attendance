using Base.Application.Contracts.Users;

namespace Base.Application.Services.Interfaces;

public interface IUserService
{
    Task<Result<UserProfileResponse>> GetProfileAsync(string userId);
    Task<Result> UpdateProfileAsync(string userId, UpdateProfileRequest request);
    Task<Result<string>> ChangeImageAsync(string userId, ChangeProfileImageRequest image);
    Task<Result> ChangePasswordAsync(string userId, ChangePasswordRequest request);
    Task<Result<UserResponse>> AddAsync(CreateUserRequest request);
    Task<IEnumerable<UserResponse>> GetAllAsync();
    Task<Result<string>> DeleteAsync(string email);
}
