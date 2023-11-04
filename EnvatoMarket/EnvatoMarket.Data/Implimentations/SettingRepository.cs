using System;
using System.Linq;
using System.Linq.Expressions;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.Data.Implimentations
{
	public class SettingRepository:Repository<Setting>,ISettingRepository
	{
        private readonly AppDbContext _context;
        private readonly DbSet<Setting> Table;
       
        public SettingRepository(AppDbContext context) : base(context)
        {
            _context = context;
            Table = _context.Set<Setting>();
        }

        public async Task<Dictionary<string, string>> GetSettingByKeyValue(Expression<Func<Setting, bool>> predicate = null, params string[] includes)
        {
            IQueryable<Setting> query = Table;
            try
            {
                if (includes.Length > 0)
                {
                    query = GetAllIncludes(includes);
                }
                return predicate == null ? await query.ToDictionaryAsync(s=>s.Key,s=>s.Value) : await query.Where(predicate).ToDictionaryAsync(s=>s.Key,s=>s.Value);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}

