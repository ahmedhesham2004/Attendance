using Base.Application.Contracts.Users;

namespace Base.Application.Services.Implementations;

public class UserService(UserManager<ApplicationUser> _userManager, ApplicationDbContext _context, IFileService _fileService, IRoleService _roleService) : IUserService
{
    public async Task<Result<UserProfileResponse>> GetProfileAsync(string userId)
    {
        var user = await _userManager.Users
            .Where(x => x.Id == userId)
            .ProjectToType<UserProfileResponse>()
            .SingleAsync();

        var user2 = await _userManager.Users
            .Where(x => x.Id == userId)
            .SingleAsync();

        var role = await _userManager.GetRolesAsync(user2);
        user.Role = role;

        return Result.Success(user);
    }
    public async Task<Result> UpdateProfileAsync(string userId, UpdateProfileRequest request)
    {
        await _userManager.Users.Where(x => x.Id == userId)
            .ExecuteUpdateAsync(setters => setters
                    .SetProperty(x => x.FirstName, request.FirstName)
                    .SetProperty(x => x.LastName, request.LastName)
                    .SetProperty(x => x.Sex, request.Sex)
                    .SetProperty(x => x.PhoneNumber, request.PhoneNumber)
                    .SetProperty(x => x.NationalId, request.NationalId)
            );

        return Result.Success();
    }
    public async Task<Result<string>> ChangeImageAsync(string userId, ChangeProfileImageRequest request)
    {
        var user = await _userManager.Users.SingleAsync(x => x.Id == userId);

        await _fileService.DeleteAsync(user.ImageUrl);

        var imageUrl = await _fileService.UploadAsync(request.Image, "profiles");

        user.ImageUrl = imageUrl;
        await _userManager.UpdateAsync(user);

        return Result.Success(imageUrl);
    }

    public async Task<Result> ChangePasswordAsync(string userId, ChangePasswordRequest request)
    {
        var user = await _userManager.FindByIdAsync(userId);

        var result = await _userManager.ChangePasswordAsync(user!, request.CurrentPassword, request.NewPassword);

        return result.Succeeded ? Result.Success() : Result.Failure(new Error(result.Errors.First().Code, result.Errors.First().Description, StatusCodes.Status400BadRequest));
    }

    public async Task<Result<UserResponse>> AddAsync(CreateUserRequest request)
    {
        var emailIsExists = await _userManager.Users.AnyAsync(x => x.Email == request.Email);
        if (emailIsExists)
            return Result.Failure<UserResponse>(UserErrors.DuplicatedEmail);

        var allowedRoles = (await _roleService.GetAllAsync()).Value.Select(x => x.Name);
        if (request.Roles.Except(allowedRoles).Any())
            return Result.Failure<UserResponse>(UserErrors.InvalidRoles);

        var user = request.Adapt<ApplicationUser>();
        user.EmailConfirmed = true;
        user.ImageUrl = "profiles/Default-Image.jpg";
        var result = await _userManager.CreateAsync(user, request.Password);
        if (result.Succeeded)
        {
            await _userManager.AddToRolesAsync(user, request.Roles);

            var response = user.Adapt<UserResponse>();

            return Result.Success(response);
        }

        var error = result.Errors.First();

        return Result.Failure<UserResponse>(new Error(error.Code, error.Description, StatusCodes.Status400BadRequest));
    }

    public async Task<IEnumerable<UserResponse>> GetAllAsync()
    {
        var users = await _userManager.Users
            .ToListAsync();

        var userResponses = new List<UserResponse>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);

            var userResponse = user.Adapt<UserResponse>();
            userResponse.Roles = await _userManager.GetRolesAsync(user);

            userResponses.Add(userResponse);
        }

        return userResponses;
    }

    public async Task<Result<string>> DeleteAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user is null)
            return Result.Failure<string>(UserErrors.UserNotFound);

        var result = await _userManager.DeleteAsync(user);

        return !result.Succeeded
            ? Result.Failure<string>(new Error("BadRequest", result.Errors.First().Description, StatusCodes.Status400BadRequest))
            : Result.Success("User deleted successfully");
    }

}
