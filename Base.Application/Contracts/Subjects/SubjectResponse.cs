using Base.Application.Contracts.Department;
using Base.Application.Contracts.Doctor;

namespace Base.Application.Contracts.Subjects;
public class SubjectResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Samester { get; set; }
    public DoctorResponseWithoutSubject Doctor { get; set; } = null!;
    public DepartmentResponse Department { get; set; } = null!;

    public ICollection<Lecture> Lectures { get; set; }
}
