using Base.Application.Contracts.Students;

namespace Base.Application.Contracts.Attendences;
public class StudentAttendenceResponse
{
    public StudentResponse2 Student { get; set; }

    public int LectureId { get; set; }
    public Lecture Lecture { get; set; }
}
