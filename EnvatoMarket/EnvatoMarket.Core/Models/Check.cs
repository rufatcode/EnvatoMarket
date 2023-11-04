using System;
using EnvatoMarket.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnvatoMarket.Core.Models
{
    public class Check:BaseEntity
    {
        public double TotalAmmount { get; set; }
        [ForeignKey(nameof(AppUser))]
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<CheckProduct> CheckProducts { get; set; }
        public Check()
        {
            CheckProducts = new();
        }

    }
}

