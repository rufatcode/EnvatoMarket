using System;
using System.ComponentModel.DataAnnotations;

namespace EnvatoMarket.Business.ViewModels.AdressVM
{
	public class CreateAdressVM
	{
        [MinLength(4)]
        public string CompanyName { get; set; }
        [MinLength(4)]
        public string Addres1 { get; set; }
        [MinLength(4)]
        public string Addres2 { get; set; }
        [MinLength(4)]
        public string Country { get; set; }
        [MinLength(4)]
        public string City { get; set; }
        [MinLength(4)]
        public string State { get; set; }
        [MinLength(4)]
        public string ZipCode { get; set; }
        public CreateAdressVM()
		{
		}
	}
}

