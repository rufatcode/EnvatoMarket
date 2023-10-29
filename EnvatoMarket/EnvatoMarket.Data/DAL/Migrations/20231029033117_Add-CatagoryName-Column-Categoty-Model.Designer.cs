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
    [Migration("20231029033117_Add-CatagoryName-Column-Categoty-Model")]
    partial class AddCatagoryNameColumnCategotyModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EnvatoMarket.Core.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatagoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Removed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

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
                            Id = "6f171b63-8614-4843-8272-f7af2e242b94",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(470),
                            IsDeleted = false,
                            Key = "Hotline",
                            Value = "+48 500 500 500"
                        },
                        new
                        {
                            Id = "5d2640f8-6098-4912-aed7-ccb77c56d833",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(470),
                            IsDeleted = false,
                            Key = "Logo",
                            Value = "logo.png"
                        },
                        new
                        {
                            Id = "15be1877-2079-4c60-8a2c-2d1b526de8a3",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(480),
                            IsDeleted = false,
                            Key = "Location",
                            Value = "45 Grand Central Terminal New York,NY 1017 United State USA"
                        },
                        new
                        {
                            Id = "f1d5100f-546b-4f66-88c5-6d192f2deb6f",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(490),
                            IsDeleted = false,
                            Key = "PhoneNumber",
                            Value = "+994513004484"
                        },
                        new
                        {
                            Id = "20a886db-1075-474f-8fa6-6fc62fe09722",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(500),
                            IsDeleted = false,
                            Key = "Email",
                            Value = "rufatri@code.edu.az"
                        },
                        new
                        {
                            Id = "043ef68c-a273-46d6-ab39-34ec2bc0cea3",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(500),
                            IsDeleted = false,
                            Key = "Work Time",
                            Value = "Mon-Sat 9:00pm - 5:00pm Sun:Closed"
                        },
                        new
                        {
                            Id = "4d5abb53-80f9-4ac5-b115-856ee9a762df",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(510),
                            IsDeleted = false,
                            Key = "Payment",
                            Value = "payment.png"
                        },
                        new
                        {
                            Id = "3ad2ffed-c014-4fdd-b6f2-7ea9243a53cb",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(520),
                            IsDeleted = false,
                            Key = "CompanyEmail",
                            Value = "rft.smayilov@bk.ru"
                        },
                        new
                        {
                            Id = "85331695-9ae4-49b0-b5bc-432dff5c5e06",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(530),
                            IsDeleted = false,
                            Key = "currency1",
                            Value = "USD$"
                        },
                        new
                        {
                            Id = "e96c06c9-b1dc-4109-ae89-97ee55b7e5d1",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(530),
                            IsDeleted = false,
                            Key = "currency2",
                            Value = "EUR$"
                        },
                        new
                        {
                            Id = "b224073b-2d22-4c12-b682-7ab56485af12",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(540),
                            IsDeleted = false,
                            Key = "Language1",
                            Value = "English"
                        },
                        new
                        {
                            Id = "105e2481-4368-41da-b887-a1520a7a0b3d",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(550),
                            IsDeleted = false,
                            Key = "Language2",
                            Value = "Franch"
                        },
                        new
                        {
                            Id = "f7cc72ef-017c-4afd-b2e7-1afd461afa4a",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(560),
                            IsDeleted = false,
                            Key = "Flag1",
                            Value = "1.jpg"
                        },
                        new
                        {
                            Id = "d13f72c2-2ecc-4e5c-9512-de9b3d3facf2",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(560),
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

                    b.Property<string>("MainTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Removed")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubTitle")
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
                            Id = "39164a35-c093-405f-b2a7-ba45bc27d3c4",
                            AccessFailedCount = 0,
                            AddedBy = "System",
                            ConcurrencyStamp = "8f1335ad-342c-4d0f-9f67-78aa705c0f5c",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 521, DateTimeKind.Local).AddTicks(310),
                            Email = "rufatri@code.edu.az",
                            EmailConfirmed = true,
                            FullName = "Rufat Azerbaijan",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RUFATRI@CODE.EDU.AZ",
                            NormalizedUserName = "RUFATCODE",
                            PasswordHash = "AQAAAAEAACcQAAAAEF94ompodu9SEnMUyInrveu1LjEehx/pEc0at7o6jkyRbLjq/pR/SOc6Hlx6FmV99g==",
                            PhoneNumber = "+994513004484",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "fabba85d-cc87-474c-9808-5b4358794698",
                            TwoFactorEnabled = false,
                            UserName = "RufatCode"
                        },
                        new
                        {
                            Id = "5f9456e8-be42-4703-813d-cf9c485ccb1a",
                            AccessFailedCount = 0,
                            AddedBy = "System",
                            ConcurrencyStamp = "2a47a571-8fd6-4d59-b2cb-360cc2f4583a",
                            Created = new DateTime(2023, 10, 29, 7, 31, 17, 521, DateTimeKind.Local).AddTicks(340),
                            Email = "rft.smayilov@bk.ru",
                            EmailConfirmed = true,
                            FullName = "Rufat Code",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RFT.SMAYILOV@BK.RU",
                            NormalizedUserName = "RUFAT_2003",
                            PasswordHash = "AQAAAAEAACcQAAAAEIWLgnuiZsTaJo+f2ty9IOz0Zv742kurfgL+gVJVwVKE7mWfs1A1lOA73D7QGRN44g==",
                            PhoneNumber = "+994513004484",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "c79aa197-b275-4c37-8863-e78e143bfe4e",
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
                            Id = "c2fb5820-ffe2-4f64-b248-d024537f5a9a",
                            ConcurrencyStamp = "c85792a8-556c-4d56-915f-5960f3efa448",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "9a972cdc-f95e-422b-9225-412864eda6ae",
                            ConcurrencyStamp = "bd34b627-b4f9-48c2-8347-ccf61f008990",
                            Name = "SupperAdmin",
                            NormalizedName = "SUPPERADMIN"
                        },
                        new
                        {
                            Id = "4dbef8aa-3e45-4ab9-9d63-95d54c914574",
                            ConcurrencyStamp = "c97f5acd-5e8b-4a43-bf5f-ef9f9b35753b",
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
                            UserId = "39164a35-c093-405f-b2a7-ba45bc27d3c4",
                            RoleId = "c2fb5820-ffe2-4f64-b248-d024537f5a9a"
                        },
                        new
                        {
                            UserId = "5f9456e8-be42-4703-813d-cf9c485ccb1a",
                            RoleId = "9a972cdc-f95e-422b-9225-412864eda6ae"
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

            modelBuilder.Entity("EnvatoMarket.Core.Models.Category", b =>
                {
                    b.HasOne("EnvatoMarket.Core.Models.Category", "Parent")
                        .WithMany("Categories")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
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

            modelBuilder.Entity("EnvatoMarket.Core.Models.Category", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}