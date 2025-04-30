using Base.Application.Contracts.Nfc_Cards;

namespace Base.Application.Services.Interfaces;
public interface INfc_CardService
{
    Task<Result<List<Nfc_CardResponse>>> GetAllAsync();
    Task<Result<Nfc_CardResponse>> GetAsync(int id);

    Task<Result<Nfc_CardResponse>> CreateAsync(Nfc_CardRequest request);
    Task<Result> UpdateAsync(int id, Nfc_CardRequest request);
    Task<Result> DeleteAsync(int id);
}
