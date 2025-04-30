namespace Base.Application.Contracts.Students;
public record StudentRequest
(
     string ApplicationUserId,
     int DepartmentId,
     int LevelId
);
