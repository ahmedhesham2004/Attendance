using Microsoft.AspNetCore.Http;

namespace Base.Domain.Errors;
public class DoctorError
{
    public static readonly Error NotFound
      = new("Doctor.NotFound", "Doctor is not exists", StatusCodes.Status404NotFound);
    public static readonly Error Dublicated
      = new("Doctor.Dublicated", "Doctor is already exists", StatusCodes.Status409Conflict);
}
