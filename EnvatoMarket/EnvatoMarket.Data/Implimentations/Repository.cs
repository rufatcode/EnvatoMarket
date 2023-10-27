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
            try
            {
                var resoult = _context.Entry(entity);
                resoult.State = EntityState.Added;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task Delete(T entity)
        {
            try
            {
                var resoult = _context.Entry(entity);
                resoult.State = EntityState.Deleted;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<List<T>> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null, params string[] includes)
        {
            IQueryable<T> query = Table ;
            try
            {
                if (includes.Length > 0)
                {
                    query = GetAllIncludes(includes);
                }
                return predicate == null ? await query.ToListAsync() : await query.Where(predicate).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
           
        }

        public async Task<T> GetEntity(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null, params string[] includes)
        {
            try
            {
                IQueryable<T> query = Table;
                if (includes.Length > 0)
                {
                    query = GetAllIncludes(includes);
                }
                return predicate == null ? await query.FirstOrDefaultAsync() : await query.FirstOrDefaultAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<bool> IsExist(System.Linq.Expressions.Expression<Func<T, bool>> predicate=null)
        {

            try
            {
                return predicate == null ? false : await Table.AnyAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
         public IQueryable<T> GetAllIncludes(params string[] includes)
        {
            try
            {
                IQueryable<T> query = Table;
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        public async Task Update(T entity)
        {
            try
            {
                var resoult = _context.Entry(entity);
                resoult.State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}

