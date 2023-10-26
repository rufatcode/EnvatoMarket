using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EnvatoMarket.Core.Interfaces;

namespace EnvatoMarket.Core.Models
{
	public abstract  class BaseEntity
    {
		[Key]
		public string Id { get; set; }
		public DateTime Created { get; set; } = DateTime.Now;
		public DateTime? Removed { get; set; }
		public DateTime? Updated { get; set; }
		public string AddedBy { get; set; } = "System";
		public bool IsDeleted { get; set; }
		
	}
}

