using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.SliderVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class SliderProfile:Profile
	{

		public SliderProfile()
		{
			CreateMap<CreateSliderVM,Slider>();
			CreateMap<UpdateSliderVM, Slider>();
			CreateMap<Slider, UpdateSliderVM>();
		}
	}
}

