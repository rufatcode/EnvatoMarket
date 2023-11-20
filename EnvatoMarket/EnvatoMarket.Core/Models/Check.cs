using System;
using EnvatoMarket.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnvatoMarket.Core.Models
{
    public class Check:BaseEntity
    {
        public double TotalAmmount { get; set; }
        public double Sale { get; set; }
        [ForeignKey(nameof(Adress))]
        public string AdressId { get; set; }
        public Adress Adress { get; set; }
        public List<CheckProduct> CheckProducts { get; set; }
        public Check()
        {
            CheckProducts = new();
        }

    }
}

