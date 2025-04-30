using Microsoft.AspNetCore.Http;

namespace Base.Domain.Errors;
public class SubjectError
{
    public static readonly Error NotFound
     = new("Subject.NotFound", "Subject is not exists", StatusCodes.Status404NotFound);

    public static readonly Error Duplicated
    = new("Subject.Duplicated", "Subject is already exists with same name", StatusCodes.Status409Conflict);
}
