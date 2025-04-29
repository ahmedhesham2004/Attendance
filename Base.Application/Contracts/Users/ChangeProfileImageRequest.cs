namespace Base.Application.Contracts.Users;

public class ChangeProfileImageRequest
{
    public IFormFile Image { get; set; } = null!;
}
