using System;
using System.ComponentModel.DataAnnotations;
using EnvatoMarket.Business.ElementAttributes;

namespace EnvatoMarket.Business.ViewModels.UsersVM
{
	public class UserUpdateVM
	{
        [Required, EnsureOneElement(ErrorMessage = "At least a person is required")]
		public IList<string> Roles { get; set; }
        [Required,MinLength(5)]
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        [Required,DataType(DataType.EmailAddress),EmailAddress]
        public string Email { get; set; }
        [RegularExpression(@"^\+994(50|51|55|70|77|99)+\d{7}$")]
        public string? PhoneNumber { get; set; }
        [Required, MinLength(5)]
        public string UserName { get; set; }
        public bool IsDeleted { get; set; }
        public UserUpdateVM()
		{
		}
	}
}

