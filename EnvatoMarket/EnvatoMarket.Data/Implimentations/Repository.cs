using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.Data.Implimentations
{
	public class Repository<T>:IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> Table;
		public Repository(AppDbContext context)
		{
            _context = context;
            Table = _context.Set<T>();
		}

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public async  Task Create(T entity)
        {
            var resoult = _context.Entry(entity);
            resoult.State = EntityState.Added;
        }

        public async Task Delete(T entity)
        {
            var resoult = _context.Entry(entity);
            resoult.State = EntityState.Deleted;
        }

        public async Task<List<T>> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null, params string[] includes)
        {
            IQueryable<T> query = Table ;
            if (includes.Length>0)
            {
                query= GetAllIncludes(includes);
            }
            return predicate == null ? await query.ToListAsync() :await query.Where(predicate).ToListAsync();
           
        }

        public async Task<T> GetById(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null, params string[] includes)
        {
            IQueryable<T> query = Table;
            if (includes.Length>0)
            {
                query = GetAllIncludes(includes);
            }
            return predicate == null ? await query.FirstOrDefaultAsync() : await query.FirstOrDefaultAsync(predicate);
        }

        public async Task<bool> IsExist(System.Linq.Expressions.Expression<Func<T, bool>> predicate=null)
        {

            return predicate == null ? false :await Table.AnyAsync(predicate);
        }
         public IQueryable<T> GetAllIncludes(params string[] includes)
        {
            IQueryable<T> query = Table;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query;
        }
        public async Task Update(T entity)
        {
            var resoult = _context.Entry(entity);
            resoult.State = EntityState.Modified;
        }
    }
}

