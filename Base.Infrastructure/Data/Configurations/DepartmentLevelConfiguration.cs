using Base.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Base.Infrastructure.Data.Configurations;
internal class DepartmentLevelConfiguration : IEntityTypeConfiguration<DepartmentLevel>
{
    public void Configure(EntityTypeBuilder<DepartmentLevel> builder)
    {
        builder.HasKey(x => new { x.LevelId, x.DepartmentId });
    }
}
