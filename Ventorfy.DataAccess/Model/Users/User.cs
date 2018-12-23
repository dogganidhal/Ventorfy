using System;
using Ventorfy.DataAccess.Model.Inventory;

namespace Ventorfy.DataAccess.Model.Users
{
	public class User
	{
		
		public Guid Id { get; set; }
		public string UserName { get; set; }
		public string FullName { get; set; }
		public string PasswordHash { get; set; }
		public Store Store { get; set; }
		
		public User(string userName, string fullName, string passwordHash)
		{
			UserName = userName;
			FullName = fullName;
			PasswordHash = passwordHash;
		}
		
	}
}