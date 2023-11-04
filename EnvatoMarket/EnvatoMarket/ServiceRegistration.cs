﻿using System;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Mappings.AutoMapper;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.DAL;
using EnvatoMarket.Data.Implimentations;
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
				option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    opt =>

                        opt.MigrationsAssembly("EnvatoMarket.Data")
                    );
			});
			services.AddIdentity<AppUser, IdentityRole>(option =>
			{
				option.User.RequireUniqueEmail = true;
				option.SignIn.RequireConfirmedPhoneNumber = false;
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
			services.AddScoped<ISendEmail, SendEmail>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<ISliderService, SliderService>();
			services.AddScoped<ISliderRepository, SliderRepository>();
			services.AddScoped<IFileService, FileService>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IBrandRepository, BrandRepository>();
			services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductImageRepository, ProductImageRepository>();
            services.AddScoped<IProductTagRepository, ProductTagRepository>();
			services.AddScoped<IAuthorRepository, AuthorRepository>();
			services.AddScoped<IAuthorService, AuthorService>();
			services.AddScoped<IBlogRepository, BlogRepository>();
			services.AddScoped<IBlogService, BlogService>();
			services.AddScoped<IFeatureService, FeatureService>();
			services.AddScoped<IFeatureRepository, FeatureRepository>();
			services.AddScoped<ICommentRepository, CommentRepository>();
			services.AddScoped<ICommentService, CommentService>();
			services.AddScoped<ISettingRepository, SettingRepository>();
            services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<IContactRepository, ContactRepository>();
			services.AddScoped<IContactService, ContactService>();
			services.AddScoped<ISubscribeRepository, SubscribeRepository>();
			services.AddScoped<ISubscribeService, SubscribeService>();
			services.AddScoped<ICheckProductRepository, CheckProductRepository>();
			services.AddScoped<ICheckProductService, CheckProductService>();
			services.AddScoped<ICheckRepository, CheckRepository>();
			services.AddScoped<ICheckService, CheckService>();
			services.AddScoped<IBasketServices, BasketServices>();
            services.AddAutoMapper(typeof(HomeProfile).Assembly);
			services.AddAutoMapper(typeof(UserProfile).Assembly);
			services.AddAutoMapper(typeof(SliderProfile).Assembly);
			services.AddAutoMapper(typeof(CategoryProfile).Assembly);
			services.AddAutoMapper(typeof(BrandProfile).Assembly);
			services.AddAutoMapper(typeof(TagProfile).Assembly);
			services.AddAutoMapper(typeof(ProductProfile).Assembly);
			services.AddAutoMapper(typeof(AuthorProfile).Assembly);
			services.AddAutoMapper(typeof(BlogProfile).Assembly);
			services.AddAutoMapper(typeof(FeatureProfile).Assembly);
			services.AddAutoMapper(typeof(SettingProfile).Assembly);
			services.AddAutoMapper(typeof(ContactProfile).Assembly);
			services.AddAutoMapper(typeof(SubscribeProfile).Assembly);
        }
	}
}

