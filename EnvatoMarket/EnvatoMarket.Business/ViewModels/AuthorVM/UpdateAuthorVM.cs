using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EnvatoMarket.Business.ViewModels.AuthorVM
{
	public class UpdateAuthorVM
	{
        public string Name { get; set; }
        [MinLength(7)]
        public string About { get; set; }
        public IFormFile? Image { get; set; }
        [EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public UpdateAuthorVM()
		{
		}
	}
}

