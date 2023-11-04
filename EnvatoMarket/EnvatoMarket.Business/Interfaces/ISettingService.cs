using System;
using System.Linq.Expressions;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Interfaces
{
	public interface ISettingService:IService<Setting>
	{
        public Task<Dictionary<string, string>> GetSettingByKeyValue(Expression<Func<Setting, bool>> predicate = null, params string[] includes);

    }
}

