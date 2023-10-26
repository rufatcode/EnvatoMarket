using System;
namespace EnvatoMarket.Business.ViewModels.UsersVM
{
	public class UserUpdateVM
	{
		public IList<string> Roles { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string UserName { get; set; }
        public UserUpdateVM()
		{
		}
	}
}

