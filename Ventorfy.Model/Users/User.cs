using System;

namespace Ventorfy.Model.Users
{
	public class User
	{

		public int Id { get;  set; }
		public string UserName { get; set; }
		public string FullName { get; set; }
		public string PasswordHash { get; set; }
		
	}
}