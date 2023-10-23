using System;
using EnvatoMarket.DAL;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket
{
	public static class ServiceRegistration
	{
		public static void  Registration(this IServiceCollection services,ConfigurationManager configuration)
		{
            services.AddRazorPages();
            services.AddControllersWithViews();
			services.AddSession(option =>
			{
				option.IdleTimeout = TimeSpan.FromDays(10);
			});
			services.AddDbContext<AppDbContext>(option =>
			{
				option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
			});
			services.AddIdentity<AppUser, IdentityRole>(option =>
			{
				option.User.RequireUniqueEmail = true;
				option.SignIn.RequireConfirmedPhoneNumber = true;
				option.SignIn.RequireConfirmedEmail = true;
				option.Password.RequireDigit = true;
				option.Password.RequiredLength = 8;
				option.Password.RequireLowercase =true ;
				option.Password.RequireNonAlphanumeric = true;
				option.Password.RequireUppercase = true;
				option.Lockout.AllowedForNewUsers = true;
				option.Lockout.MaxFailedAccessAttempts = 3;
				option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
				option.SignIn.RequireConfirmedAccount = true;

			}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
			services.AddHttpContextAccessor();
            services.Configure<DataProtectionTokenProviderOptions>(option =>
            {
                option.TokenLifespan = TimeSpan.FromMinutes(10);

            });
        }
	}
}

