using Base.Application.Contracts.Students;

namespace Base.Application.Services.Interfaces;
public interface IStudentService
{
    Task<Result<AddStudentResponse>> AddAsync(StudentRequest request);
    Task<IEnumerable<StudentResponse>> GetAllAsync();
    Task<Result<StudentResponse>> GetAsync(string userId);
    Task<Result> DeleteAsync(int studentId);
}
