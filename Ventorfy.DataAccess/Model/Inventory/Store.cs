using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Model.Inventory
{
	public class Store
	{

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		[Required, StringLength(64)]
		public string Name { get; set; }
		
		[Required]
		public User Admin { get; set; }

	}
}