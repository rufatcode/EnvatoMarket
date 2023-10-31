using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.AuthorVM
{
	public class CreateAuthorVM
	{
        public string Name { get; set; }
        [MinLength(7)]
        public string About { get; set; }
        public IFormFile Image { get; set; }
        [EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public CreateAuthorVM()
		{
		}
	}
}

