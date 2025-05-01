namespace Base.Application.Contracts.Subjects;
public class SubjectRequest
{
    public string Name { get; set; }
    public string Code { get; set; }
    public int Samester { get; set; }
    public int DoctorId { get; set; }
    public int DepartmentId { get; set; }
    public int LevelId { get; set; }
}
