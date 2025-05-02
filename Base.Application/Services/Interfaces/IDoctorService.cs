using Base.Application.Contracts.Doctor;

namespace Base.Application.Services.Interfaces;
public interface IDoctorService
{
    Task<Result<List<DoctorResponse>>> GetAllAsync();
    Task<Result<DoctorResponse>> GetAsync(string userId);
    Task<Result<DoctorResponse>> CreateAsync(DoctorRequest request);
    Task<Result> DeleteAsync(int id);
}
