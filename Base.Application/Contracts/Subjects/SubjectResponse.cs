using Base.Application.Contracts.Attendences;
using Base.Application.Contracts.Department;
using Base.Application.Contracts.Doctor;

namespace Base.Application.Contracts.Subjects;
public class SubjectResponse
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string LevelName { get; set; }
    public string DepartmentName { get; set; }
    public int Samester { get; set; }
    public string DoctorName { get; set; }
    public ICollection<AttendenceResponse> Attendences { get; set; }
}