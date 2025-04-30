using Microsoft.AspNetCore.Http;

namespace Base.Domain.Errors;
public class DepartmentError
{
    public static readonly Error NotFound
        = new("Department.NotFound", "Department is not exists", StatusCodes.Status404NotFound);
}
