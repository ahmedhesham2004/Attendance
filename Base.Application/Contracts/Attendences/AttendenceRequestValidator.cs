using Base.Application.Contracts.Students;

namespace Base.Application.Contracts.Attendences;
public class AttendenceRequestValidator : AbstractValidator<AttendenceRequest>
{
    public AttendenceRequestValidator()
    {
        RuleFor(x => x.StudentId)
            .NotNull();

        RuleFor(x => x.LectureId)
            .NotNull();
    }
}