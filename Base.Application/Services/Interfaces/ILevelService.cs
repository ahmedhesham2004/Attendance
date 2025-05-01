using Base.Application.Contracts.Levels;

namespace Base.Application.Services.Interfaces;
public interface ILevelService
{
    Task<Result<List<LevelResponse>>> GetAllAsync();
    Task<Result<LevelResponse>> GetAsync(int id);
    Task<Result<List<LevelWithDepartments>>> GetAllWithDepartmentsAsync();
    Task<Result<LevelWithDepartments>> GetWithDepartmentsAsync(int id);
     Task<Result<List<LevelWithStudents>>> GetAllWithStudentsAsync();
    Task<Result<LevelWithStudents>> GetWithStudentsAsync(int id); 
    Task<Result<List<LevelWithSubjects>>> GetAllWithSubjectsAsync();
    Task<Result<LevelWithSubjects>> GetWithSubjectsAsync(int id);

}
