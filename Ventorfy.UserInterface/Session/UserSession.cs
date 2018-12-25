using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.UserInterface.Session
{
	public class UserSession
	{

		public static UserSession Instance { get => new UserSession(); }

		public User CurrentUser { get; set; }

		private UserSession()
		{

		}


	}
}
