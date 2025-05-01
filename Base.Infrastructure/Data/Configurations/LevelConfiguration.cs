using Base.Domain.Consts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Base.Domain.Entities;

namespace Base.Infrastructure.Data.Configurations;
public class LevelConfiguration : IEntityTypeConfiguration<Level>
{
    public void Configure(EntityTypeBuilder<Level> builder)
    {
        var levels = new List<Level>
        {
            new Level
            {
                Id = 1,
                Name = "المستوي الاول",
            },
            new Level
            {
                Id = 2,
                Name = "المستوي الثاني",
            },
            new Level
            {
                Id = 3,
                Name = "المستوي الثالث",
            },
            new Level
            {
                Id = 4,
                Name = "المستوي الرابع",
            }
        };

        builder.HasData(levels);
    }
}