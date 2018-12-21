using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ventorfy.DataAccess.Model.Products
{
	public class ProductCategory
	{

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id{ get; set; }
		
		[Required, StringLength(64)]
		public int Name { get; set; }

	}
}