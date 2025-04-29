using Base.Domain.Entities;
using Base.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Base.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Attendence> Attendences { get; set; } = null!;
    public DbSet<Department> Departments { get; set; } = null!;
    public DbSet<Doctor> Doctors { get; set; } = null!;
    public DbSet<Lecture> Lectures { get; set; } = null!;
    public DbSet<Level> Levels { get; set; } = null!;
    public DbSet<NFC_Card> NFC_Cards { get; set; } = null!;
    public DbSet<Subject> Subjects { get; set; } = null!;
   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        modelBuilder.Entity<Student>()
        .HasOne(s => s.NFC_Card)
        .WithOne(c => c.Student)
        .HasForeignKey<NFC_Card>(c => c.StudentId);

        base.OnModelCreating(modelBuilder);
    }
}
