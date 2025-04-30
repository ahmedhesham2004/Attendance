using Base.Application.Contracts.Users;

namespace Base.Application.Contracts.Nfc_Cards;
public class Nfc_CardResponse
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string ImageUrl { get; set; }

}
