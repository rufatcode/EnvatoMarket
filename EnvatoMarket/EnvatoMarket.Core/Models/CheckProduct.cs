using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnvatoMarket.Core.Models
{
    public class CheckProduct:BaseEntity
    {
        [ForeignKey(nameof(Product))]
        public string ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey(nameof(Check))]
        public string CheckId { get; set; }
        public Check Check { get; set; }
        public double Price { get; set; }
        public int ProductCount { get; set; }
        public CheckProduct()
        {
        }
    }
}

