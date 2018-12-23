using System;
using System.Collections.Generic;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Model.Inventory
{
	public class Store
	{

		public Guid Id { get; set; }
		public string Name { get; set; }
		public User Admin { get; set; }
		public ICollection<User> StaffMembers { get; set; }

	}
}