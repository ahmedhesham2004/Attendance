using Base.Application.Contracts.Levels;
using Base.Application.Contracts.Nfc_Cards;
using Base.Application.Contracts.Users;
namespace Base.Application.Contracts.Students;
public record AddStudentResponse
(
    int Id,
    string ApplicationUserId,
    int DepartmentId,
    int LevelId
);