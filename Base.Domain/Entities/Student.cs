using Base.Domain.Entities.Identity;

namespace Base.Domain.Entities;
public class Student
{
    public int Id { get; set; }

    public string ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; } = null!;


    public NFC_Card NFC_Card { get; set; } = null!;

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public int LevelId { get; set; }
    public Level Level { get; set; } = null!;

    public ICollection<Attendence> Attendences { get; set; }

}
