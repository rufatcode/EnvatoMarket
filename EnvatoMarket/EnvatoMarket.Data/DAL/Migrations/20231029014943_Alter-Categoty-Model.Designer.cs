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
    [Migration("20231029014943_Alter-Categoty-Model")]
    partial class AlterCategotyModel
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
                            Id = "71dc1d39-47ae-46c3-bd95-3f62593eed9d",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4300),
                            IsDeleted = false,
                            Key = "Hotline",
                            Value = "+48 500 500 500"
                        },
                        new
                        {
                            Id = "d4b7b40a-0b37-4799-b227-4856ce4720d7",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4310),
                            IsDeleted = false,
                            Key = "Logo",
                            Value = "logo.png"
                        },
                        new
                        {
                            Id = "a8bb925f-17be-4b99-b46c-6cdb89188c75",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4320),
                            IsDeleted = false,
                            Key = "Location",
                            Value = "45 Grand Central Terminal New York,NY 1017 United State USA"
                        },
                        new
                        {
                            Id = "c59c1802-4c5f-420a-9f21-0bf74a653bc4",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4330),
                            IsDeleted = false,
                            Key = "PhoneNumber",
                            Value = "+994513004484"
                        },
                        new
                        {
                            Id = "c1fe39e0-6dc1-4009-91d7-604be824f67f",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4330),
                            IsDeleted = false,
                            Key = "Email",
                            Value = "rufatri@code.edu.az"
                        },
                        new
                        {
                            Id = "529628f3-08fb-4d0e-9eb1-425d1885fd0d",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4340),
                            IsDeleted = false,
                            Key = "Work Time",
                            Value = "Mon-Sat 9:00pm - 5:00pm Sun:Closed"
                        },
                        new
                        {
                            Id = "fa285056-dc8a-4c5c-83ee-4717dbcdf8f4",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4350),
                            IsDeleted = false,
                            Key = "Payment",
                            Value = "payment.png"
                        },
                        new
                        {
                            Id = "336f1d95-bb23-4319-8235-583da2c951ce",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4350),
                            IsDeleted = false,
                            Key = "CompanyEmail",
                            Value = "rft.smayilov@bk.ru"
                        },
                        new
                        {
                            Id = "5d661b4a-08ff-4c75-a237-1da581f3e7c6",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4360),
                            IsDeleted = false,
                            Key = "currency1",
                            Value = "USD$"
                        },
                        new
                        {
                            Id = "8faa032a-20e0-4f1b-af48-9d0836b8b968",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4370),
                            IsDeleted = false,
                            Key = "currency2",
                            Value = "EUR$"
                        },
                        new
                        {
                            Id = "fe5ae378-1e6e-4f6f-9521-44d846732f46",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4370),
                            IsDeleted = false,
                            Key = "Language1",
                            Value = "English"
                        },
                        new
                        {
                            Id = "e95a23cb-a240-4de2-a1b3-087d950b6fd0",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4380),
                            IsDeleted = false,
                            Key = "Language2",
                            Value = "Franch"
                        },
                        new
                        {
                            Id = "b044cf3d-4376-406a-b8a1-54b7d954c938",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4380),
                            IsDeleted = false,
                            Key = "Flag1",
                            Value = "1.jpg"
                        },
                        new
                        {
                            Id = "b2414538-dcc3-470b-b693-72ff3f5646e2",
                            AddedBy = "System",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4390),
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
                            Id = "3c88aa9a-d89e-475c-920e-9a6fd2cc8d88",
                            AccessFailedCount = 0,
                            AddedBy = "System",
                            ConcurrencyStamp = "0660bde2-5f8c-49b8-8c1a-461a2edcb654",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 133, DateTimeKind.Local).AddTicks(3800),
                            Email = "rufatri@code.edu.az",
                            EmailConfirmed = true,
                            FullName = "Rufat Azerbaijan",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RUFATRI@CODE.EDU.AZ",
                            NormalizedUserName = "RUFATCODE",
                            PasswordHash = "AQAAAAEAACcQAAAAEJv2T6JIjvv91qwvoQ/Z8+dw8ir5ZPwYbweQ5mu9JB5VeOkpHoU0qXIqkILFUmvu3w==",
                            PhoneNumber = "+994513004484",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "aae68ffd-7827-41df-ae6e-c933c7756682",
                            TwoFactorEnabled = false,
                            UserName = "RufatCode"
                        },
                        new
                        {
                            Id = "66872929-7419-4ccc-9aa7-fb8df8c57227",
                            AccessFailedCount = 0,
                            AddedBy = "System",
                            ConcurrencyStamp = "d7e519f2-923c-45bc-b6ec-4a594b5e6f7b",
                            Created = new DateTime(2023, 10, 29, 5, 49, 43, 133, DateTimeKind.Local).AddTicks(3840),
                            Email = "rft.smayilov@bk.ru",
                            EmailConfirmed = true,
                            FullName = "Rufat Code",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RFT.SMAYILOV@BK.RU",
                            NormalizedUserName = "RUFAT_2003",
                            PasswordHash = "AQAAAAEAACcQAAAAEIkrtPuow8pmqB+RxUVeBJNGaXCWAb1UmMSrA6WfXPC4zyf34rd7ETR1qbU92lwCSA==",
                            PhoneNumber = "+994513004484",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "bec609e8-a519-40e3-96ef-abf230f5a5c9",
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
                            Id = "dd7d1c98-a7eb-4129-9280-9bee374eb304",
                            ConcurrencyStamp = "da99c5b8-d43f-4ef3-86fb-0bd6c3084608",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "e6f881f4-3417-444f-9cd0-09852a6def35",
                            ConcurrencyStamp = "646e99a7-12be-417f-a471-ee18e9ffc88d",
                            Name = "SupperAdmin",
                            NormalizedName = "SUPPERADMIN"
                        },
                        new
                        {
                            Id = "77c8594e-8323-4767-a723-643e040dc3aa",
                            ConcurrencyStamp = "2f7d55d7-cbaf-4239-9bc1-6f19b0a3004a",
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
                            UserId = "3c88aa9a-d89e-475c-920e-9a6fd2cc8d88",
                            RoleId = "dd7d1c98-a7eb-4129-9280-9bee374eb304"
                        },
                        new
                        {
                            UserId = "66872929-7419-4ccc-9aa7-fb8df8c57227",
                            RoleId = "e6f881f4-3417-444f-9cd0-09852a6def35"
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