using System.ComponentModel.DataAnnotations;

namespace Base.Domain.Entities;
public class Subject
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Samester { get; set; }
    public string Code { get; set; }

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; } = null!;

    public int LevelId { get; set; }
    public Level Level { get; set; } = null!;

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public ICollection<Attendence> Attendences { get; set; }
}
