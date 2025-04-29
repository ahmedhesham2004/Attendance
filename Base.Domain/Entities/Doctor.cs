using Base.Domain.Entities.Identity;
using System.Reflection.Metadata.Ecma335;

namespace Base.Domain.Entities;
public class Doctor 
{
    public int Id { get; set; }

    public int ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; } = null!;

    public List<Subject> Subjects { get; set; }
}
