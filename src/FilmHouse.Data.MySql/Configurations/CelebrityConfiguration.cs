﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FilmHouse.Data.Entities;
using FilmHouse.Data.Core.ValueObjects;
using FilmHouse.Core.Utils.Data;

namespace FilmHouse.Data.MySql.Configurations;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
internal class CelebrityConfiguration : IEntityTypeConfiguration<CelebrityEntity>
{
    public void Configure(EntityTypeBuilder<CelebrityEntity> builder)
    {
        builder.HasKey(e => new { e.CelebrityId }).HasName("celebrity_ix00");

        builder.ToTable("Celebrity");

        builder.Property(e => e.RequestId)
            .IsRequired()
            .HasColumnType("char(36)")
            .HasMaxLength(36)
            .HasConversion<RequestIdVO.RequestIdValueConverter>();

        builder.Property(e => e.CelebrityId)
            .IsRequired()
            .HasColumnType("char(36)")
            .HasMaxLength(36)
            .HasConversion<CelebrityIdVO.CelebrityIdValueConverter>();

        builder.Property(e => e.Name)
            .IsRequired()
            .HasColumnType("varchar(50)")
            .HasMaxLength(50)
            .HasConversion<CelebrityNameVO.CelebrityNameValueConverter>();

        builder.Property(e => e.Aka)
            .HasColumnType("varchar(500)")
            .HasMaxLength(500)
            .HasConversion<CelebrityAkaVO.CelebrityAkaValueConverter>();

        builder.Property(e => e.NameEn)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50)
            .HasConversion<CelebrityNameEnVO.CelebrityNameEnValueConverter>();

        builder.Property(e => e.AkaEn)
            .HasColumnType("varchar(500)")
            .HasMaxLength(500)
            .HasConversion<CelebrityAkaEnVO.CelebrityAkaEnValueConverter>();

        builder.Property(e => e.Gender)
            .HasColumnType("tinyint unsigned")
            .HasConversion<GenderVO.GenderValueConverter>();

        builder.Property(e => e.Professions)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50)
            .HasConversion<ProfessionsVO.ProfessionsValueConverter>();

        builder.Property(e => e.Birthday)
            .HasColumnType("date")
            .HasConversion<BirthdayVO.BirthdayValueConverter>();

        builder.Property(e => e.Deathday)
            .HasColumnType("date")
            .HasConversion<DeathdayVO.DeathdayValueConverter>();

        builder.Property(e => e.BornPlace)
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .HasConversion<BornPlaceVO.BornPlaceValueConverter>();

        builder.Property(e => e.Family)
            .HasColumnType("varchar(500)")
            .HasMaxLength(500)
            .HasConversion<FamiliesVO.FamilyValueConverter>();

        builder.Property(e => e.Avatar)
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .HasConversion<StarAvatarVO.StarAvatarValueConverter>();

        builder.Property(e => e.WorksId)
            .HasColumnType("varchar(1000)")
            .HasMaxLength(1000)
            .HasConversion<WorksVO.WorksValueConverter>();

        builder.Property(e => e.DoubanID)
            .HasColumnType("varchar(10)")
            .HasMaxLength(10)
            .HasConversion<DoubanIDVO.DoubanIDValueConverter>();

        builder.Property(e => e.IMDb)
            .HasColumnType("varchar(10)")
            .HasMaxLength(10)
            .HasConversion<IMDbVO.IMDbValueConverter>();

        builder.Property(e => e.Summary)
            .HasComment("Variable-length character data, ⇐ 2G")
            .HasColumnType("longtext")
            .HasConversion<SummaryVO.SummaryValueConverter>();

        builder.Property(e => e.UserId)
            .IsRequired()
            .HasColumnType("char(36)")
            .HasMaxLength(36)
            .HasConversion<UserIdVO.UserIdValueConverter>();

        builder.Property(e => e.ReviewStatus)
            .HasDefaultValue(typeof(ReviewStatusVO).CreateValueObjectInstance("0"))
            .HasColumnType("tinyint unsigned")
            .HasConversion<ReviewStatusVO.ReviewStatusValueConverter>();

        builder.Property(e => e.Note)
            .HasColumnType("varchar(1000)")
            .HasMaxLength(1000)
            .HasConversion<NoteVO.NoteValueConverter>();

        builder.Property(e => e.CreatedOn)
            .IsRequired()
            .HasColumnType("datetime(3)")
            .HasConversion<CreatedOnVO.CreatedOnValueConverter>();

        builder.Property(e => e.UpDatedOn)
            .HasColumnType("datetime(3)")
            .HasConversion<UpDatedOnVO.UpDatedOnValueConverter>();

    }
}