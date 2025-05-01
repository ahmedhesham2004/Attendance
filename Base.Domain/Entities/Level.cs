using System.ComponentModel.DataAnnotations;

namespace Base.Domain.Entities;
public class Level
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }


    public ICollection<Subject> Subjects { get; set; }
    public ICollection<Student> Students { get; set; }
    public ICollection<DepartmentLevel> DepartmentLevels { get; set; }
}
