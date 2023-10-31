﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.BlogVM
{
	public class UpdateBlogVM
	{
        [MinLength(5)]
        public string Title { get; set; }
        [MinLength(10)]
        public string Content { get; set; }
        public IFormFile? Image { get; set; }
        public bool IsDeleted { get; set; }
        public UpdateBlogVM()
		{
		}
	}
}

