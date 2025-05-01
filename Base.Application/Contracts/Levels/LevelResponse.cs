using Base.Application.Contracts.Department;
using Base.Application.Contracts.Students;
using Base.Application.Contracts.Subjects;

namespace Base.Application.Contracts.Levels;
public  class LevelResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
   
}
public class LevelWithDepartments
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<DepartmentResponse> Departments { get; set; }
}
public class LevelWithSubjects
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> SubjectsName { get; set; }
}
public class LevelWithStudents
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> StudentsName { get; set; }
}