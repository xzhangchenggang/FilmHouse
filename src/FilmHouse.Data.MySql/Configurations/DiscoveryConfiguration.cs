﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FilmHouse.Data.Entities;
using FilmHouse.Data.Core.ValueObjects;
using FilmHouse.Core.Utils.Data;

namespace FilmHouse.Data.MySql.Configurations;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
internal class DiscoveryConfiguration : IEntityTypeConfiguration<DiscoveryEntity>
{
    public void Configure(EntityTypeBuilder<DiscoveryEntity> builder)
    {
        builder.HasKey(e => new { e.DiscoveryId }).HasName("discovery_ix00");

        builder.ToTable("Discovery");

        builder.Property(e => e.RequestId)
            .IsRequired()
            .HasColumnType("char(36)")
            .HasMaxLength(36)
            .HasConversion<RequestIdVO.RequestIdValueConverter>();

        builder.Property(e => e.DiscoveryId)
            .IsRequired()
            .HasColumnType("char(36)")
            .HasMaxLength(36)
            .HasConversion<DiscoveryIdVO.DiscoveryIdVOValueConverter>();

        builder.Property(e => e.MovieId)
            .IsRequired()
            .HasColumnType("char(36)")
            .HasMaxLength(36)
            .HasConversion<MovieIdVO.MovieIdValueConverter>();

        builder.Property(e => e.Avatar)
            .IsRequired()
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .HasConversion<DiscoveryAvatarVO.DiscoveryAvatarVOValueConverter>();

        builder.Property(e => e.Order)
            .IsRequired()
            .HasColumnType("numeric(3)")
            .HasConversion<SortOrderVO.SortOrderValueConverter>();

        builder.Property(e => e.CreatedOn)
            .IsRequired()
            .HasColumnType("datetime(3)")
            .HasConversion<CreatedOnVO.CreatedOnValueConverter>();

        builder.Property(e => e.UpDatedOn)
            .HasColumnType("datetime(3)")
            .HasConversion<UpDatedOnVO.UpDatedOnValueConverter>();

    }
}