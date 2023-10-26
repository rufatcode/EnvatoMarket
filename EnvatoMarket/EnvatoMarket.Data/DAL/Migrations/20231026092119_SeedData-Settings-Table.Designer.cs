﻿// <auto-generated />
using System;
using EnvatoMarket.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231026092119_SeedData-Settings-Table")]
    partial class SeedDataSettingsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EnvatoMarket.Core.Models.Setting", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Removed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = "4fd33652-f5be-4b11-b702-29199dfd9054",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3290),
                            IsDeleted = false,
                            Key = "Hotline",
                            Value = "+48 500 500 500"
                        },
                        new
                        {
                            Id = "76d79839-d2d6-4830-b742-582cdd445d24",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3300),
                            IsDeleted = false,
                            Key = "Logo",
                            Value = "logo.png"
                        },
                        new
                        {
                            Id = "c2ac7d8a-1df7-4803-83d2-b5ebd103bc76",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3310),
                            IsDeleted = false,
                            Key = "Location",
                            Value = "45 Grand Central Terminal New York,NY 1017 United State USA"
                        },
                        new
                        {
                            Id = "fcc4bc4d-b5c6-4a53-b1d7-fd85c76421a0",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3310),
                            IsDeleted = false,
                            Key = "PhoneNumber",
                            Value = "+994513004484"
                        },
                        new
                        {
                            Id = "5457bafc-d225-4304-ab0e-0e11b1f703ad",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3320),
                            IsDeleted = false,
                            Key = "Email",
                            Value = "rufatri@code.edu.az"
                        },
                        new
                        {
                            Id = "e9703f0b-1c16-4ad3-adac-7c6074b7838a",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3320),
                            IsDeleted = false,
                            Key = "Work Time",
                            Value = "Mon-Sat 9:00pm - 5:00pm Sun:Closed"
                        },
                        new
                        {
                            Id = "90c4b4a9-5ff6-4ac3-ab65-24863ac4056a",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3330),
                            IsDeleted = false,
                            Key = "Payment",
                            Value = "payment.png"
                        },
                        new
                        {
                            Id = "e139ea9a-565d-4605-a8e2-231b0322d617",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3340),
                            IsDeleted = false,
                            Key = "CompanyEmail",
                            Value = "rft.smayilov@bk.ru"
                        });
                });

            modelBuilder.Entity("EnvatoMarket.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Removed")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8805b3a3-c184-40b9-965c-791ef2878349",
                            AccessFailedCount = 0,
                            AddedBy = "System",
                            ConcurrencyStamp = "e1ebac52-2a61-4c2c-954d-e6c64daf3f96",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 877, DateTimeKind.Local).AddTicks(3180),
                            Email = "rufatri@code.edu.az",
                            EmailConfirmed = true,
                            FullName = "Rufat Azerbaijan",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RUFATRI@CODE.EDU.AZ",
                            NormalizedUserName = "RUFATCODE",
                            PasswordHash = "AQAAAAEAACcQAAAAELj9zi3/UthYkCXqgDfm0KEeVTnrPOHEauCUNnNV0vs10hTIMuOhXP+Ukus/KTNHdA==",
                            PhoneNumber = "+994513004484",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "fc912cf0-6467-4e84-912b-a93d73577056",
                            TwoFactorEnabled = false,
                            UserName = "RufatCode"
                        },
                        new
                        {
                            Id = "cc278d60-10b0-4fe5-bbab-1f37f52ec6fc",
                            AccessFailedCount = 0,
                            AddedBy = "System",
                            ConcurrencyStamp = "dc222511-2c15-4635-a4f7-a72e73bc01ba",
                            Created = new DateTime(2023, 10, 26, 13, 21, 18, 877, DateTimeKind.Local).AddTicks(3210),
                            Email = "rft.smayilov@bk.ru",
                            EmailConfirmed = true,
                            FullName = "Rufat Code",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RFT.SMAYILOV@BK.RU",
                            NormalizedUserName = "RUFAT_2003",
                            PasswordHash = "AQAAAAEAACcQAAAAEBAzx0LwyluNrC3MTX0xDFgpeHdVP9iPJ0nhfrUuRdernjXpvomlVVneX726WoIYaA==",
                            PhoneNumber = "+994513004484",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "b18ed504-773f-4d15-b870-a8b840218e86",
                            TwoFactorEnabled = false,
                            UserName = "Rufat_2003"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "bd2a1712-6eb2-4e61-b981-4780b2f3f847",
                            ConcurrencyStamp = "e670119a-fe3e-406c-a8d8-e73d408a97b9",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "e04dd46c-c7b9-4027-b5ae-61824adb2e7c",
                            ConcurrencyStamp = "705e7813-b56c-4372-a2a2-8694ca314798",
                            Name = "SupperAdmin",
                            NormalizedName = "SUPPERADMIN"
                        },
                        new
                        {
                            Id = "71db3f4a-582a-4823-ac38-b07069f2c058",
                            ConcurrencyStamp = "62c77d4c-d01f-4e5a-9e15-e8c3cdb56526",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8805b3a3-c184-40b9-965c-791ef2878349",
                            RoleId = "bd2a1712-6eb2-4e61-b981-4780b2f3f847"
                        },
                        new
                        {
                            UserId = "cc278d60-10b0-4fe5-bbab-1f37f52ec6fc",
                            RoleId = "e04dd46c-c7b9-4027-b5ae-61824adb2e7c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EnvatoMarket.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EnvatoMarket.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvatoMarket.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EnvatoMarket.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
