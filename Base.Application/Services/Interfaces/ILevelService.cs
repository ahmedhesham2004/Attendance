using Base.Application.Contracts.Levels;

namespace Base.Application.Services.Interfaces;
public interface ILevelService
{
    Task<Result<List<LevelResponse>>> GetAllAsync();
    Task<Result<LevelResponse>> GetAsync(int id);
}
