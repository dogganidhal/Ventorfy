using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ventorfy.DataAccess.Model.Inventory;

namespace Ventorfy.DataAccess.Model.Products
{
	public class ProductLot
	{

		public int Id { get; set; }
		public Product Product { get; set; }
		public int Quantity { get; set; }
		public Store Store { get; set; }

	}
}