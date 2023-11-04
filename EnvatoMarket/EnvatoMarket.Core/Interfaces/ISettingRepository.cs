using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Core.Interfaces
{
	public interface ISettingRepository:IRepository<Setting>
	{
		 public Task<Dictionary<string,string>> GetSettingByKeyValue(Expression<Func<Setting, bool>> predicate = null, params string[] includes);
    }
}

