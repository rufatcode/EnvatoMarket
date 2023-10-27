using System;
using EnvatoMarket.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.ViewComponents
{
	public class ContactViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;
		public ContactViewComponent(AppDbContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _context.Settings.ToDictionaryAsync(s => s.Key,s=>s.Value) ;
			return View(await Task.FromResult(data));
		}
	}
}

