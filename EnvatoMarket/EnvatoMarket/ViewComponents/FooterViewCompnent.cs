using System;
using EnvatoMarket.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.ViewComponents
{
	public class FooterViewCompnent:ViewComponent
	{
		private readonly AppDbContext _context;
		public FooterViewCompnent(AppDbContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _context.Settings.ToListAsync();
			return View(await Task.FromResult(data));
		}
	}
}

