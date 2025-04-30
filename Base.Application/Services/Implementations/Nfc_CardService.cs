using Base.Application.Contracts.Levels;
using Base.Application.Contracts.Nfc_Cards;
using Microsoft.AspNetCore.Hosting;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using Base.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Base.Application.Services.Implementations;
public class Nfc_CardService(IWebHostEnvironment webHostEnvironment, ApplicationDbContext context) : INfc_CardService
{
    private readonly string _imagesPath = $"{webHostEnvironment.WebRootPath}/images";
    private readonly ApplicationDbContext _Context = context;

    public async Task<Result<List<Nfc_CardResponse>>> GetAllAsync()
    {
        return Result.Success(await _Context.NFC_Cards.Include(x => x.Student).AsNoTracking().ProjectToType<Nfc_CardResponse>().ToListAsync());
    }

    public async Task<Result<Nfc_CardResponse>> GetAsync(int id)
    {
        var level = await _Context.NFC_Cards
            .Where(x => x.Id == id)
            .Include(x => x.Student)
            .ProjectToType<Nfc_CardResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return level is null
            ? Result.Failure<Nfc_CardResponse>(Nfc_CardError.NotFound)
            : Result.Success(level);
    }
    public async Task<Result<Nfc_CardResponse>> CreateAsync(Nfc_CardRequest request)
    {
        if (await _Context.NFC_Cards.Where(x => x.Code == request.Code).AnyAsync()
            || await _Context.NFC_Cards.Where(x => x.StudentId == request.StudentId).AnyAsync())
            return Result.Failure<Nfc_CardResponse>(Nfc_CardError.DublicateCard);

        //if (await _Context.NFC_Cards.Where(x => x.StudentId == request.StudentId).AnyAsync())
        //    return Result.Failure<Nfc_CardResponse>(Nfc_CardError.DublicateCard);

        // Process image file
        string filename = request.ImageUrl.FileName;
        var path = Path.Combine(_imagesPath, filename);
        using (var stream = File.Create(path))
        {
            await request.ImageUrl.CopyToAsync(stream);
        }

        var nfc = request.Adapt<NFC_Card>();
        nfc.ImageUrl = $"images/{filename}";

       await _Context.NFC_Cards.AddAsync(nfc);
        await _Context.SaveChangesAsync();

        return Result.Success(nfc.Adapt<Nfc_CardResponse>());
    }
    public async Task<Result> UpdateAsync(int id, Nfc_CardRequest request)
    {
        var card = await _Context.NFC_Cards.FindAsync(id);
        if (card is null)
            return Result.Failure<Nfc_CardResponse>(Nfc_CardError.NotFound);

        string filename = request.ImageUrl.FileName;
        var path = Path.Combine(_imagesPath, filename);
        using (var stream = File.Create(path))
        {
            await request.ImageUrl.CopyToAsync(stream);
        }

        card= request.Adapt(card);
        card.ImageUrl = $"images/{filename}";

        await _Context.SaveChangesAsync();

        return Result.Success();

    }
    public async Task<Result> DeleteAsync(int id)
    {
        if (await _Context.NFC_Cards.FindAsync(id) is not { } nfc)
            return Result.Failure<Nfc_CardResponse>(Nfc_CardError.NotFound);

       _Context.NFC_Cards.Remove(nfc);

        await _Context.SaveChangesAsync();

        return Result.Success();
    }
}
