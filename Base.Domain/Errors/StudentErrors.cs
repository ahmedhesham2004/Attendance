using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Errors;
public class StudentErrors
{
    public static readonly Error StudentNotFound
      = new("StudentNotFound", "Student is not found", StatusCodes.Status404NotFound);

    public static readonly Error DublicatedUserId
      = new("DublicateUserId", "Another  Student has same UserId", StatusCodes.Status409Conflict);

}
