using Base.Domain.Consts;

namespace Base.Application.Contracts.Authentication.Validators;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    private readonly ApplicationDbContext _applicationDbContext;
    public RegisterRequestValidator(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
        var applicationDbContext1 = applicationDbContext;

        RuleFor(x => x.FirstName).NotEmpty().Length(3, 100);
        RuleFor(x => x.LastName).NotEmpty().Length(3, 100);

        RuleFor(x => x.Email).NotEmpty().EmailAddress()
            .Must(email => !applicationDbContext1.Users.Any(n => n.Email == email)).WithMessage(UserErrors.DuplicatedEmail.Description);

        RuleFor(s => s.NationalId).NotEmpty();


        RuleFor(s => s.PhoneNumber)
            .Matches(@"^(010|011|012|015)")
            .WithMessage("Invalid phone number, must start with 010, 011, 012, or 015.")
            .Length(11).WithMessage("Invalid phone number, must end with 11 numbers.");

        RuleFor(x => x.Sex).NotEmpty()
            .Must(x => x is "Male" or "Female").WithMessage("Sex must be either 'Male' or 'Female'");


        RuleFor(x => x.Password)
            .NotEmpty()
            .Matches(RegexPatterns.Password).WithMessage("Password should be at least 8 digits and should contains Lowercase, NonAlphanumeric and Uppercase");

        RuleFor(x => x.ConfirmPassword)
            .Equal(x => x.Password).WithMessage("Passwords do not match. Please make sure both password fields are identical");

        /*RuleFor(s => s.ProfileImage)
            .NotNull()
            .Must(ValidateFile)
            .WithMessage("Invalid file. Allowed file types are .jpg, .jpeg, .png, and max size is 5MB.");*/


    }
    private static bool ValidateFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return false;

        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
        var extension = Path.GetExtension(file.FileName).ToLower();

        if (!allowedExtensions.Contains(extension))
            return false;


        const long maxFileSize = 5 * 1024 * 1024; // 5MB
        return file.Length <= maxFileSize;
    }

}
