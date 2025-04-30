using Base.Application.Contracts.Comon;
using Base.Application.Settings;
using FluentValidation;

namespace Base.Application.Contracts.Nfc_Cards;
public class Nfc_CardValidator:AbstractValidator<Nfc_CardRequest>
{
    public Nfc_CardValidator()
    {
        RuleFor(x=>x.Code).NotEmpty().MaximumLength(150);

        RuleFor(x=>x.StudentId).NotEmpty();

        RuleFor(x => x.ImageUrl)
           .SetValidator(new FileSizeValidator())
           .SetValidator(new BlockedSignaturesValidator())
           .SetValidator(new FileNameValidator());

        RuleFor(x => x.ImageUrl)
            .Must((request, context) =>
            {
                var extension = Path.GetExtension(request.ImageUrl.FileName.ToLower());
                return FileSettings.AllowedImagesExtensions.Contains(extension);
            })
            .WithMessage("File extension is not allowed")
            .When(x => x.ImageUrl is not null);

        
    }
   
}
