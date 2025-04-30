using Base.Application.Contracts.Users;
using Base.Domain.Consts;

namespace Base.Application.Contracts.Students;
public class StudentRequestValidator : AbstractValidator<StudentRequest>
{
    public StudentRequestValidator()
    {
        RuleFor(x => x.ApplicationUserId)
            .NotNull();

        RuleFor(x => x.LevelId)
            .NotNull();

        RuleFor(x => x.DepartmentId)
            .NotNull();
    }
}