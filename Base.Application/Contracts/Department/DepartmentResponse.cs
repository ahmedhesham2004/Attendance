namespace Base.Application.Contracts.Department;
public class DepartmentResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
  //  public List<string> StudentsName { get; set; }
    public List<string> SubjectsName { get; set; }
    public List<string> StudentsName { get; set; }
}
