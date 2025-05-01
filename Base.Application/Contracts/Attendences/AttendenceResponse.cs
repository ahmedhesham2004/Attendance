using Base.Application.Contracts.Students;
using Base.Application.Contracts.Subjects;
using System.Text.Json.Serialization;

namespace Base.Application.Contracts.Attendences;
public class AttendenceResponse
{
    public string StudentName { get; set; }
    public string SubjectName { get; set; }
    public int Count { get; set; }
}
