namespace Base.Domain.Entities;
public class Attendence
{
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;

    public int LectureId { get; set; }
    public Lecture Lecture { get; set; } = null!;
}
