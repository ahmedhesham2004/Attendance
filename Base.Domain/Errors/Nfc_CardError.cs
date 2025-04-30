using Microsoft.AspNetCore.Http;

namespace Base.Domain.Errors;
public class Nfc_CardError
{
    public static readonly Error NotFound
       = new("NFC_Card.NotFound", "NFC_Card is not exists", StatusCodes.Status404NotFound);
  
    public static readonly Error DublicateCard
      = new("NFC_Card.Dublicate", "another  NFC_Card has same code / Student ", StatusCodes.Status409Conflict);

 
}
