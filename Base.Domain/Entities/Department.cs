using System.ComponentModel.DataAnnotations;

namespace Base.Domain.Entities;
public class Department
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }


    public ICollection<Student> Students { get; set; }
    public ICollection<Subject> Subjects { get; set; }
}
