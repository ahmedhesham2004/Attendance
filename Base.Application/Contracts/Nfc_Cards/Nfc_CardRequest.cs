namespace Base.Application.Contracts.Nfc_Cards;
public class Nfc_CardRequest
{
    public string Code { get; set; }
    public IFormFile ImageUrl { get; set; }

    public int? StudentId { get; set; }
}
