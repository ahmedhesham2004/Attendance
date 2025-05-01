using Base.Application.Contracts.Doctor;
using Base.Application.Contracts.Subjects;

namespace Base.Application.Services.Interfaces;
public interface ISubjectService
{
    Task<Result<List<SubjectResponse>>> GetAllAsync();
    Task<Result<SubjectResponse>> GetAsync(int id);

    Task<Result<SubjectResponse2>> CreateAsync(SubjectRequest request);
    Task<Result> UpdateAsync(int id, SubjectRequest request);
    Task<Result> DeleteAsync(int id);
}
