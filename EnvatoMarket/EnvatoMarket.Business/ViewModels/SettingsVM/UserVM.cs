using System;
namespace EnvatoMarket.Business.ViewModels.HomeVM
{
	public class UserVM
	{
		public string FullName { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string ProfileImageUrl { get; set; }
		public string PhoneNumber { get; set; }

        public UserVM()
		{
		}
	}
}

