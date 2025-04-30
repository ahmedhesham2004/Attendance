using Base.Application.Contracts.Comon;

namespace Base.Application.Contracts.Subjects;
public class SubjectValidator:AbstractValidator<SubjectRequest>
{
    public SubjectValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Samester)
            .NotEmpty();

        RuleFor(x => x.DepartmentId)
           .NotEmpty();

        RuleFor(x => x.DoctorId)
           .NotEmpty();
    }
}
