namespace Base.Application.Contracts.Doctor;
public class DoctorValidator:AbstractValidator<DoctorRequest>
{
    public DoctorValidator()
    {
        RuleFor(x=>x.ApplicationUserId).NotEmpty();
    }
}
