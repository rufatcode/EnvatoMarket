using System;
using System.Linq.Expressions;

namespace EnvatoMarket.Core.Interfaces
{
	public interface IRepository<T>
	{
		public Task Create(T entity);
		public Task Delete(T entity);
		public Task Update(T entity);
		public Task<T> GetEntity(Expression<Func<T, bool>> predicate = null, params string[] includes);
		public Task<List<T>> GetAll(Expression<Func<T, bool>> predicate = null, params string[] includes);
		public Task Commit();
		public Task<bool> IsExist(Expression<Func<T, bool>> predicate=null);
	}
}

