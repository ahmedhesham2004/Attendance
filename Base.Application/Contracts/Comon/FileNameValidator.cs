﻿namespace Base.Application.Contracts.Comon;
public class FileNameValidator : AbstractValidator<IFormFile>
{
    public FileNameValidator()
    {
        RuleFor(x => x.FileName)
            .Matches("^[A-Za-z0-9_\\-.]*$")
            .WithMessage("Invalid file name")
            .When(x => x is not null);
    }
}
