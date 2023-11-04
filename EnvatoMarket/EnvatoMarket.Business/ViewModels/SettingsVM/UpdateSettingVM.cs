using System;
namespace EnvatoMarket.Business.ViewModels.SettingsVM
{
	public class UpdateSettingVM
	{
        public bool IsDeleted { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public UpdateSettingVM()
		{
		}
	}
}

