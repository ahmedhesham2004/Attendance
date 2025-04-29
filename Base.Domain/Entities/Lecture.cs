using System.ComponentModel.DataAnnotations;

namespace Base.Domain.Entities;
public class Lecture
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Lecturedate { get; set; }
    public string Code { get; set; }


    public int SubjectId { get; set; }
    public Subject Subject { get; set; }

    public ICollection<Attendence> Attendences { get; set; }
}
