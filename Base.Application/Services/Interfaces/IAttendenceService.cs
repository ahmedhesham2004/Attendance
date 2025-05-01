using Base.Application.Contracts.Attendences;

namespace Base.Application.Services.Interfaces;
public interface IAttendenceService
{

    Task<IEnumerable<AttendenceResponse>> GetAllAsync();
    //Task<Result<ICollection<SubjectAttendenceResponse>>> GetSubjectAttendenceAsync(int subjectId);
    
}
