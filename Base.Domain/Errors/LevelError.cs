using Microsoft.AspNetCore.Http;

namespace Base.Domain.Errors;
public class LevelError
{
    public static readonly Error NotFound
        = new("Level.NotFound", "Level is not exists", StatusCodes.Status404NotFound);
}
