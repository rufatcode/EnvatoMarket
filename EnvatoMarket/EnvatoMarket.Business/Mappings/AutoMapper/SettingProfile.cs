using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.SettingsVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class SettingProfile:Profile
	{
		public SettingProfile()
		{
			CreateMap<CreateSettingVM, Setting>();
			CreateMap<UpdateSettingVM, Setting>();
			CreateMap<Setting, UpdateSettingVM>();
        }
	}
}

