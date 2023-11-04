using System;
using EnvatoMarket.Business.ViewModels.BasketsVM;

namespace EnvatoMarket.Business.Interfaces
{
	public interface IBasketServices
	{
        void Add(string id);
        void Decrease(string id, string data);
        void Increase(string id, string data);
        void Remove(string id, string data);
        Task<List<BasketVM>> Show();
    }
}

