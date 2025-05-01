using Base.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Base.Infrastructure.Data.Configurations;
public class DepartmentLevelConfiguration : IEntityTypeConfiguration<DepartmentLevel>
{
    public void Configure(EntityTypeBuilder<DepartmentLevel> builder)
    {
        builder.HasKey(x => new { x.LevelId, x.DepartmentId });

        var departmentLevels = new List<DepartmentLevel>
        {
            new DepartmentLevel
            {
                DepartmentId = 1,
                LevelId = 1,
            }
        };

        //builder.HasData(departmentLevels);
    }
}
