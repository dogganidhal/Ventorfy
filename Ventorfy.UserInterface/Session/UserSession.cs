using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.UserInterface.Session
{
	public class UserSession
	{

		public static UserSession Instance { get; } = new UserSession();

		private User _CurrentUser;

		private UserSession()
		{

		}

		public void SetCurrentUser(User user)
		{
			this._CurrentUser = user;
		}

		public User GetCurrentUser()
		{
			return this._CurrentUser;
		}

	}
}
