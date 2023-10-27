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
    [Migration("20231027111709_Slider-Model")]
    partial class SliderModel
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
                            Id = "7d4459f1-5031-4b3c-9b92-835191af0cbf",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(820),
                            IsDeleted = false,
                            Key = "Hotline",
                            Value = "+48 500 500 500"
                        },
                        new
                        {
                            Id = "d31a3e27-f745-4e7e-b1b6-db0c4c3ece95",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(830),
                            IsDeleted = false,
                            Key = "Logo",
                            Value = "logo.png"
                        },
                        new
                        {
                            Id = "1bba2a6a-6bf4-446a-babe-c0fd180aab92",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(830),
                            IsDeleted = false,
                            Key = "Location",
                            Value = "45 Grand Central Terminal New York,NY 1017 United State USA"
                        },
                        new
                        {
                            Id = "f962c4c4-f466-4e35-b5de-ba6aaf456923",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(840),
                            IsDeleted = false,
                            Key = "PhoneNumber",
                            Value = "+994513004484"
                        },
                        new
                        {
                            Id = "33d0af2b-16a5-4b14-a555-74a9c9e2356d",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(850),
                            IsDeleted = false,
                            Key = "Email",
                            Value = "rufatri@code.edu.az"
                        },
                        new
                        {
                            Id = "f67b03df-f705-4276-a74d-f87e9b81492e",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(850),
                            IsDeleted = false,
                            Key = "Work Time",
                            Value = "Mon-Sat 9:00pm - 5:00pm Sun:Closed"
                        },
                        new
                        {
                            Id = "076519ce-da54-460d-8b10-5f3f48f86cbb",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(860),
                            IsDeleted = false,
                            Key = "Payment",
                            Value = "payment.png"
                        },
                        new
                        {
                            Id = "9f574046-1192-4dca-80b4-6b2686fdb8d7",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(870),
                            IsDeleted = false,
                            Key = "CompanyEmail",
                            Value = "rft.smayilov@bk.ru"
                        },
                        new
                        {
                            Id = "e504fc56-3647-4fd2-af11-1904473cf338",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(870),
                            IsDeleted = false,
                            Key = "currency1",
                            Value = "USD$"
                        },
                        new
                        {
                            Id = "f8a8c633-dd3a-4ea9-a780-13396de6d903",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(880),
                            IsDeleted = false,
                            Key = "currency2",
                            Value = "EUR$"
                        },
                        new
                        {
                            Id = "18bb6124-0b68-401c-890d-cf2eda9c4915",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(890),
                            IsDeleted = false,
                            Key = "Language1",
                            Value = "English"
                        },
                        new
                        {
                            Id = "be41e6cb-a420-4fd2-a86d-6af5b5af9ee2",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(890),
                            IsDeleted = false,
                            Key = "Language2",
                            Value = "Franch"
                        },
                        new
                        {
                            Id = "99b2c592-50db-4abb-8f43-c4fa872d10b4",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(900),
                            IsDeleted = false,
                            Key = "Flag1",
                            Value = "1.jpg"
                        },
                        new
                        {
                            Id = "59576887-0af9-4d94-89f1-02e0fdea56b3",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(910),
                            IsDeleted = false,
                            Key = "Flag2",
                            Value = "2.jpg"
                        });
                });

            modelBuilder.Entity("EnvatoMarket.Core.Models.Slider", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Removed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
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
                            Id = "4f18dd5b-3242-4700-9c18-55053e21f8d0",
                            AccessFailedCount = 0,
                            AddedBy = "System",
                            ConcurrencyStamp = "1211e6dc-c4d2-4556-bdc9-f26032cce955",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 822, DateTimeKind.Local).AddTicks(9830),
                            Email = "rufatri@code.edu.az",
                            EmailConfirmed = true,
                            FullName = "Rufat Azerbaijan",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RUFATRI@CODE.EDU.AZ",
                            NormalizedUserName = "RUFATCODE",
                            PasswordHash = "AQAAAAEAACcQAAAAEIne1aeXlMmyo4MsL4QQ6x7pLEpPKc434xIGRWaYgTY0n0BB1CkKwzjstHigvZGk1A==",
                            PhoneNumber = "+994513004484",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "08d77937-4ec5-4490-8d16-081dbc9fc9dd",
                            TwoFactorEnabled = false,
                            UserName = "RufatCode"
                        },
                        new
                        {
                            Id = "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6",
                            AccessFailedCount = 0,
                            AddedBy = "System",
                            ConcurrencyStamp = "3bc81311-e283-4b12-a4a5-f3e60d38b999",
                            Created = new DateTime(2023, 10, 27, 15, 17, 8, 822, DateTimeKind.Local).AddTicks(9870),
                            Email = "rft.smayilov@bk.ru",
                            EmailConfirmed = true,
                            FullName = "Rufat Code",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RFT.SMAYILOV@BK.RU",
                            NormalizedUserName = "RUFAT_2003",
                            PasswordHash = "AQAAAAEAACcQAAAAELuqdvcvHGI6h+v/fR1y628aGSZTuOe+8/PbWAXIofqvwt1vqDwDu+n3BidzRcVjsg==",
                            PhoneNumber = "+994513004484",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "02563ed5-fbfe-4a50-b671-ae2b5485f68f",
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
                            Id = "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82",
                            ConcurrencyStamp = "cb108a99-12c9-450c-a147-d78325e6f193",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "8ff757ef-cb02-4336-b7af-6c551ff8d660",
                            ConcurrencyStamp = "3673f12f-8ee9-49f3-88b9-66651a787eee",
                            Name = "SupperAdmin",
                            NormalizedName = "SUPPERADMIN"
                        },
                        new
                        {
                            Id = "13cad7c1-3ff8-4085-b22c-faf7f48d82c3",
                            ConcurrencyStamp = "f3acb702-b6f3-4da1-9576-01005768fa99",
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
                            UserId = "4f18dd5b-3242-4700-9c18-55053e21f8d0",
                            RoleId = "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82"
                        },
                        new
                        {
                            UserId = "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6",
                            RoleId = "8ff757ef-cb02-4336-b7af-6c551ff8d660"
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