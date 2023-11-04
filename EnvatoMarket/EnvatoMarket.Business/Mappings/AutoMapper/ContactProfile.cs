using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.ContactVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class ContactProfile:Profile
	{

		public ContactProfile()
		{
			CreateMap<UpdateContactVM, Contact>();
			CreateMap<Contact, UpdateContactVM>();
        }
	}
}

