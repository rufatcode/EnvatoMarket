using System;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.DAL
{
	public class AppDbContext:IdentityDbContext<AppUser>
	{
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public AppDbContext(DbContextOptions options):base(options)
		{
		}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
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
                PhoneNumberConfirmed = true,
                Created = DateTime.Now,
                AddedBy = "System"
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
                PhoneNumberConfirmed = true,
                Created = DateTime.Now,
                AddedBy="System"

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
            builder.Entity<Setting>().HasData(new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "Hotline",
                Value = "+48 500 500 500",
                AddedBy = "System",
                Created = DateTime.Now,
            },
            new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "Logo",
                Value = "logo.png",
                AddedBy = "System",
                Created = DateTime.Now
            }, new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "Location",
                Value = "45 Grand Central Terminal New York,NY 1017 United State USA",
                AddedBy = "System",
                Created = DateTime.Now
            }, new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "PhoneNumber",
                Value = "+994513004484",
                AddedBy = "System",
                Created = DateTime.Now
            }, new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "Email",
                Value = "rufatri@code.edu.az",
                AddedBy = "System",
                Created = DateTime.Now
            }, new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "Work Time",
                Value = "Mon-Sat 9:00pm - 5:00pm Sun:Closed",
                AddedBy = "System",
                Created = DateTime.Now
            },new Setting
            {
                Id=Guid.NewGuid().ToString(),
                Key="Payment",
                Value= "payment.png",
                AddedBy="System",
                Created=DateTime.Now
            }, new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "CompanyEmail",
                Value = "rft.smayilov@bk.ru",
                AddedBy = "System",
                Created = DateTime.Now
            },new Setting
            {
                Id=Guid.NewGuid().ToString(),
                Key= "currency1",
                Value="USD$",
                AddedBy = "System",
                Created = DateTime.Now
            }, new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "currency2",
                Value = "EUR$",
                AddedBy = "System",
                Created = DateTime.Now
            },
            new Setting
            {
                Id=Guid.NewGuid().ToString(),
                Key="Language1",
                Value="English",
                AddedBy = "System",
                Created = DateTime.Now
            },
            new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "Language2",
                Value = "Franch",
                AddedBy = "System",
                Created = DateTime.Now
            },
            new Setting
            {
                Id=Guid.NewGuid().ToString(),
                Key="Flag1",
                Value= "1.jpg",
                AddedBy = "System",
                Created = DateTime.Now
            },
            new Setting
            {
                Id = Guid.NewGuid().ToString(),
                Key = "Flag2",
                Value = "2.jpg",
                AddedBy = "System",
                Created = DateTime.Now
            });
            base.OnModelCreating(builder); 
        }
    }
}

