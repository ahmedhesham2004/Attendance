namespace Base.Application.Contracts.Levels;
public  class LevelResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Student> Students { get; set; }
}
