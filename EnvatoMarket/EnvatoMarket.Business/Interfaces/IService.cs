using System;
using System.Linq.Expressions;

namespace EnvatoMarket.Business.Interfaces
{
	public interface IService<T>
	{
		public Task<bool> Create(T entity);
		public Task<bool> Delete(int id);
		public Task<bool> Update(T entity);
		public Task<T> GetById(int id, Expression<Func<T, bool>> predicate = null, params string[] includes);
		public Task<List<T>> GetAll(Expression<Func<T, bool>> predicate=null,params string[] includes);
	}
}

