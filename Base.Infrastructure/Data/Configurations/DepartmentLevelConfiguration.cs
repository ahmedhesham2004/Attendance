﻿using Base.Domain.Entities;
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
            },
            new DepartmentLevel
            {
                DepartmentId = 1,
                LevelId = 2,
            },
            new DepartmentLevel
            {
                DepartmentId = 2,
                LevelId = 1,
            },
            new DepartmentLevel
            {
                DepartmentId = 2,
                LevelId = 2,
            },
            new DepartmentLevel
            {
                DepartmentId = 2,
                LevelId = 3,
            },
            new DepartmentLevel
            {
                DepartmentId = 2,
                LevelId = 4,
            },
            new DepartmentLevel
            {
                DepartmentId = 3,
                LevelId = 1,
            },
            new DepartmentLevel
            {
                DepartmentId = 3,
                LevelId = 2,
            },
            new DepartmentLevel
            {
                DepartmentId = 3,
                LevelId = 3,
            },
            new DepartmentLevel
            {
                DepartmentId = 3,
                LevelId = 4,
            },
            new DepartmentLevel
            {
                DepartmentId = 4,
                LevelId = 1,
            },
            new DepartmentLevel
            {
                DepartmentId = 4,
                LevelId = 2,
            },
            new DepartmentLevel
            {
                DepartmentId = 4,
                LevelId = 3,
            },
            new DepartmentLevel
            {
                DepartmentId = 4,
                LevelId = 4,
            },
            new DepartmentLevel
            {
                DepartmentId = 5,
                LevelId = 1,
            },
            new DepartmentLevel
            {
                DepartmentId = 5,
                LevelId = 2,
            },
            new DepartmentLevel
            {
                DepartmentId = 5,
                LevelId = 3,
            },
            new DepartmentLevel
            {
                DepartmentId = 5,
                LevelId = 4,
            },
        };

        builder.HasData(departmentLevels);
    }
}
