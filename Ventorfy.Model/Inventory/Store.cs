using System;
using Ventorfy.Model.Users;

namespace Ventorfy.Model.Inventory
{
	public class Store
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public User Admin { get; set; }

	}
}