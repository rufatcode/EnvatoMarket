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
	}
}

