namespace Base.Domain.Entities;
public class Attendence
{
    public int Id { get; set; }
    public int Count { get; set; } = 0;
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;

    public int SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;
}
