﻿using FilmHouse.Core.Utils.Data;
using FilmHouse.Data.Core.ValueObjects;
using FilmHouse.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilmHouse.Data.SqlServer.Configurations;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
internal class UserAccountConfiguration : IEntityTypeConfiguration<UserAccountEntity>
{
    public void Configure(EntityTypeBuilder<UserAccountEntity> builder)
    {
        builder.HasKey(e => new { e.UserId });
        builder.HasAnnotation("SqlServer:Name", "user_account_ix00");

        builder.ToTable("UserAccount");

        builder.Property(e => e.RequestId)
            .IsRequired()
            .HasColumnType("uniqueidentifier")
            .HasConversion<RequestIdVO.RequestIdValueConverter>();

        builder.Property(e => e.UserId)
            .IsRequired()
            .HasColumnType("uniqueidentifier")
            .HasConversion<UserIdVO.UserIdValueConverter>();

        builder.Property(e => e.Account)
            .IsRequired()
            .HasColumnType("varchar(50)")
            .HasMaxLength(50)
            .HasConversion<AccountNameVO.AccountNameValueConverter>();

        builder.Property(e => e.Password)
            .IsRequired()
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasConversion<PasswordVO.PasswordVOValueConverter>();

        builder.Property(e => e.EmailAddress)
            .IsRequired()
            .HasColumnType("varchar(256)")
            .HasMaxLength(256)
            .HasConversion<EmailAddressVO.EmailAddressVOValueConverter>();

        builder.Property(e => e.Avatar)
            .HasColumnType("varchar(256)")
            .HasMaxLength(256)
            .HasConversion<UserAvatarVO.UserAvatarVOValueConverter>();

        builder.Property(e => e.Cover)
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasConversion<CoverVO.CoverValueConverter>();

        builder.Property(e => e.IsAdmin)
            .HasDefaultValue(typeof(IsAdminVO).CreateValueObjectInstance("false"))
            .HasColumnType("bit")
            .HasConversion<IsAdminVO.IsAdminVOValueConverter>();

        builder.Property(e => e.CreatedOn)
            .IsRequired()
            .HasColumnType("datetime")
            .HasConversion<CreatedOnVO.CreatedOnValueConverter>();

        builder.Property(e => e.UpDatedOn)
            .HasColumnType("datetime")
            .HasConversion<UpDatedOnVO.UpDatedOnValueConverter>();
    }
}