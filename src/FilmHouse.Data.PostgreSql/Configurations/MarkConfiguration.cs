﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FilmHouse.Data.Entities;
using FilmHouse.Data.Core.ValueObjects;
using FilmHouse.Core.Utils.Data;

namespace FilmHouse.Data.PostgreSql.Configurations;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
internal class MarkConfiguration : IEntityTypeConfiguration<MarkEntity>
{
    public void Configure(EntityTypeBuilder<MarkEntity> builder)
    {
        builder.HasKey(e => new { e.MarkId }).HasName("mark_ix00");

        builder.ToTable("Mark");

        builder.Property(e => e.RequestId)
            .IsRequired()
            .HasColumnType("uuid")
            .HasConversion<RequestIdVO.RequestIdValueConverter>();

        builder.Property(e => e.MarkId)
            .IsRequired()
            .HasColumnType("uuid")
            .HasConversion<MarkIdVO.MarkIdValueConverter>();

        builder.Property(e => e.Type)
            .IsRequired()
            .HasDefaultValue(typeof(MarkTypeVO).CreateValueObjectInstance("0"))
            .HasColumnType("smallint")
            .HasConversion<MarkTypeVO.MarkTypeValueConverter>();

        builder.Property(e => e.UserId)
            .IsRequired()
            .HasColumnType("uuid")
            .HasConversion<UserIdVO.UserIdValueConverter>();

        builder.Property(e => e.Target)
            .IsRequired()
            .HasColumnType("uuid")
            .HasConversion<MarkTargetVO.MarkTargetValueConverter>();

        builder.Property(e => e.CreatedOn)
            .IsRequired()
            .HasColumnType("timestamp(3)")
            .HasConversion<CreatedOnVO.CreatedOnValueConverter>();

        builder.Property(e => e.UpDatedOn)
            .HasColumnType("timestamp(3)")
            .HasConversion<UpDatedOnVO.UpDatedOnValueConverter>();

    }
}