namespace Base.Domain.Entities;
public class DepartmentLevel
{
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public int LevelId { get; set; }
    public Level Level { get; set; }
}
