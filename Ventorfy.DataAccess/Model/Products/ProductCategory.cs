using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ventorfy.DataAccess.Model.Products
{
	public class ProductCategory
	{

		public int Id{ get; set; }
		public int Name { get; set; }

	}
}