using System.ComponentModel.DataAnnotations;

namespace Base.Domain.Entities;
public class NFC_Card
{    
    public int Id { get; set; }
    public string Code { get; set; }
    public string ImageUrl { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }

}
