using System;
namespace EnvatoMarket.Business.ViewModels.UsersVM
{
	public class GetUserVM
	{
		public string ProfileImageUrl { get; set; }
		public string Id { get; set; }
		public string UserName { get; set; }
		public IList<string> Roles { get; set; }
		public string Email { get; set; }
		public string? PhoneNumber { get; set; }
		public string AddedBy { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
		public DateTime? Removed { get; set; }
		public bool IsDeleted { get; set; }
		public bool IsActive { get; set; }
        public GetUserVM()
		{
		}
	}
}

