using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ventorfy.DataAccess.Model.Inventory
{
	public class Provider
	{
		
		public Guid Id { get; set; }
		public string Name { set; get; }
		
	}
}