﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FilmHouse.Data.Entities;

namespace FilmHouse.Data.PostgreSql.Configurations;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
internal class CelebrityConfiguration : IEntityTypeConfiguration<CelebrityEntity>
{
    public void Configure(EntityTypeBuilder<CelebrityEntity> builder)
    {
        builder.HasKey(e => new { e.CelebrityId });
        builder.HasAnnotation("SqlServer:Name", "celebrity_ix00");

        builder.ToTable("Celebrity");

        builder.Property(e => e.RequestId)
            .IsRequired()
            .HasColumnType("uniqueidentifier");

        builder.Property(e => e.CelebrityId)
            .IsRequired()
            .HasColumnType("uniqueidentifier");

        builder.Property(e => e.Name)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);

        builder.Property(e => e.Aka)
            .HasColumnType("varchar(max)");

        builder.Property(e => e.NameEn)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);

        builder.Property(e => e.AkaEn)
            .HasColumnType("varchar(max)");

        builder.Property(e => e.Gender)
            .HasColumnType("tinyint");

        builder.Property(e => e.Occupation)
            .HasColumnType("varchar(max)");

        builder.Property(e => e.Birthday)
            .HasColumnType("varchar(10)")
            .HasMaxLength(10);

        builder.Property(e => e.Deathday)
            .HasColumnType("varchar(10)")
            .HasMaxLength(10);

        builder.Property(e => e.BornPlace)
            .HasColumnType("varchar(100)")
            .HasMaxLength(10);

        builder.Property(e => e.Family)
            .HasColumnType("varchar(max)");

        builder.Property(e => e.Avatar)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);

        builder.Property(e => e.Works)
            .HasColumnType("varchar(max)");

        builder.Property(e => e.DoubanID)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);

        builder.Property(e => e.IMDb)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);

        builder.Property(e => e.Summary)
            .HasColumnType("varchar(max)");

        builder.Property(e => e.UserId)
            .IsRequired()
            .HasColumnType("uniqueidentifier");

        builder.Property(e => e.ReviewStatus)
            .HasColumnType("varchar(10)")
            .HasMaxLength(10);

        builder.Property(e => e.ReviewNote)
            .HasColumnType("varchar(100)")
            .HasMaxLength(100);

        builder.Property(e => e.CreatedOn)
            .IsRequired()
            .HasColumnType("datetime");

        builder.Property(e => e.UpDatedOn)
            .HasColumnType("datetime");

    }
}