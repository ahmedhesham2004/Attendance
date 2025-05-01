using Base.Application.Contracts.Students;

namespace Base.Application.Services.Implementations;
public class StudentService(ApplicationDbContext context, UserManager<ApplicationUser> _userManager) : IStudentService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<AddStudentResponse>> AddAsync(StudentRequest request)
    {
        var isExstingUserId = await _context.ApplicationUsers.AnyAsync(x => x.Id == request.ApplicationUserId);
        if (!isExstingUserId)
            return Result.Failure<AddStudentResponse>(UserErrors.UserNotFound);

        var isExstingLevelId = await _context.Levels.AnyAsync(x => x.Id == request.LevelId);
        if (!isExstingLevelId)
            return Result.Failure<AddStudentResponse>(LevelError.NotFound);

        var isExstingDepartmentId = await _context.Departments.AnyAsync(x => x.Id == request.DepartmentId);
        if (!isExstingDepartmentId)
            return Result.Failure<AddStudentResponse>(DepartmentError.NotFound);

        var UserIdUsed = await _context.Students.AnyAsync(x => x.ApplicationUserId == request.ApplicationUserId);
        if (UserIdUsed)
            return Result.Failure<AddStudentResponse>(StudentErrors.DublicatedUserId);

        var student = request.Adapt<Student>();

        var user = await _userManager.FindByIdAsync(request.ApplicationUserId);
        _userManager.AddToRoleAsync(user, "User").Wait();

        await _context.AddAsync(student);
        await _context.SaveChangesAsync();


        return Result.Success(student.Adapt<AddStudentResponse>());
    }
    public async Task<IEnumerable<StudentResponse>> GetAllAsync() =>
        await _context.Students
                .Include(x => x.ApplicationUser)
                .Include(x => x.Level)
                .Include(x => x.Department)
                .Include(x => x.NFC_Card)
                .Include(x => x.Attendences)
                .ProjectToType<StudentResponse>()
                .AsNoTracking()
                .ToListAsync();
    public async Task<Result<StudentResponse>> GetAsync(string userId)
    {
        var studentId = await _context.Students
            .Where(x => x.ApplicationUserId == userId)
            .Select(x => x.Id)
            .FirstOrDefaultAsync();

        var student = await _context.Students
            .Where(x => x.Id == studentId)
            .Include(x => x.ApplicationUser)
            .Include(x => x.Level)
            .Include(x => x.Department)
            .Include(x => x.NFC_Card)
            .Include(x => x.Attendences)
            .ProjectToType<StudentResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return student is null ? Result.Failure<StudentResponse>(StudentErrors.StudentNotFound) : Result.Success(student);
    }
    public async Task<Result<AddStudentResponse>> UpdateAsync(int studentId, StudentRequest request)
    {
        if (await _context.Students.FindAsync(studentId) is not { } student)
            return Result.Failure<AddStudentResponse>(StudentErrors.StudentNotFound);

        var isExstingUserId = await _context.ApplicationUsers.AnyAsync(x => x.Id == request.ApplicationUserId);
        if (!isExstingUserId)
            return Result.Failure<AddStudentResponse>(UserErrors.UserNotFound);

        var isExstingLevelId = await _context.Levels.AnyAsync(x => x.Id == request.LevelId);
        if (!isExstingLevelId)
            return Result.Failure<AddStudentResponse>(LevelError.NotFound);

        var isExstingDepartmentId = await _context.Departments.AnyAsync(x => x.Id == request.DepartmentId);
        if (!isExstingDepartmentId)
            return Result.Failure<AddStudentResponse>(DepartmentError.NotFound);

        var UserIdUsed = await _context.Students.AnyAsync(x => x.ApplicationUserId == request.ApplicationUserId && x.Id != studentId);
        if (UserIdUsed)
            return Result.Failure<AddStudentResponse>(StudentErrors.DublicatedUserId);


        student = request.Adapt(student);
        await _context.SaveChangesAsync();

        return Result.Success(student.Adapt<AddStudentResponse>());
    }
    public async Task<Result> DeleteAsync(int studentId)
    {
        var isExstingStudent = await _context.Students.AnyAsync(x => x.Id == studentId);
        if (!isExstingStudent)
            return Result.Failure(StudentErrors.StudentNotFound);

        _context.Students.Remove(new Student { Id = studentId });
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}