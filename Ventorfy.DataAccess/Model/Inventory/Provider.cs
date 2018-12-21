using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ventorfy.DataAccess.Model.Inventory
{
	public class Provider
	{
		
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		[Required, StringLength(64)]
		public string Name { set; get; }
		
	}
}