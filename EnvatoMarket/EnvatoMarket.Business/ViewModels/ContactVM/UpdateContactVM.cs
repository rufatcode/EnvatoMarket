using System;
namespace EnvatoMarket.Business.ViewModels.ContactVM
{
	public class UpdateContactVM
	{
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsDeleted { get; set; }
        public UpdateContactVM()
		{
		}
	}
}

