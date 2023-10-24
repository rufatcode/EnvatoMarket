using System;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.DAL
{
	public class AppDbContext:IdentityDbContext<AppUser>
	{
		public AppDbContext(DbContextOptions options):base(options)
		{
		}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            string AdminRoleId = Guid.NewGuid().ToString();
            string SupperAdminRoleId = Guid.NewGuid().ToString();
            string UserRoleId = Guid.NewGuid().ToString();
            string AdminId = Guid.NewGuid().ToString();
            string SupperAdminId = Guid.NewGuid().ToString();
            builder.Entity<IdentityRole>().HasData(new IdentityRole {
                Id=AdminRoleId,
                Name="Admin",
                NormalizedName="ADMIN"
            },
            new IdentityRole
            {
                Id=SupperAdminRoleId,
                Name="SupperAdmin",
                NormalizedName="SUPPERADMIN"
            },
            new IdentityRole
            {
                Id=UserRoleId,
                Name="User",
                NormalizedName="USER"
            });
            AppUser Admin = new AppUser {
                Id = AdminId,
                Email = "rufatri@code.edu.az",
                NormalizedEmail = "RUFATRI@CODE.EDU.AZ",
                NormalizedUserName = "RUFATCODE",
                UserName = "RufatCode",
                EmailConfirmed = true,
                IsActive = true,
                FullName = "Rufat Azerbaijan",
                PhoneNumber = "+994513004484",
                PhoneNumberConfirmed = true

            };
            AppUser SupperAdmin = new AppUser
            {
                Id = SupperAdminId,
                Email = "rft.smayilov@bk.ru",
                NormalizedEmail = "RFT.SMAYILOV@BK.RU",
                NormalizedUserName = "RUFAT_2003",
                UserName = "Rufat_2003",
                EmailConfirmed = true,
                IsActive = true,
                FullName = "Rufat Code",
                PhoneNumber = "+994513004484",
                PhoneNumberConfirmed = true

            };
            PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();
            string AdminPassword = hasher.HashPassword(Admin, "Rufat123.");
            string SupperAdminPassword = hasher.HashPassword(SupperAdmin, "Rufat123.");
            Admin.PasswordHash = AdminPassword;
            SupperAdmin.PasswordHash = SupperAdminPassword;
            builder.Entity<AppUser>().HasData(Admin);
            builder.Entity<AppUser>().HasData(SupperAdmin);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = AdminId,
                RoleId = AdminRoleId
                
            },
            new IdentityUserRole<string>
            {
                UserId = SupperAdminId,
                RoleId = SupperAdminRoleId,

                
            }) ;
            base.OnModelCreating(builder); 
        }
    }
}

