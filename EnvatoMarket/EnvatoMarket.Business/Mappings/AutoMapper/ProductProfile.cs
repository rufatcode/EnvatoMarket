using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.ProductVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class ProductProfile:Profile
	{
		public ProductProfile()
		{
			CreateMap<CreateProductVM, Product>();
			CreateMap<UpdateProductVM, Product>();
			CreateMap<Product, UpdateProductVM>();
        }
	}
}

