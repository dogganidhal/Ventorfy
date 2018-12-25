using System;
using System.Windows.Forms;
using Ventorfy.DataAccess.Repository;
using Ventorfy.DataAccess.Repository.Users;
using Ventorfy.UserInterface.View;

namespace Ventorfy.UserInterface
{
	static class Program
	{

		private static readonly IUserRepository _UserRepository = RepositoryFactory.Instance.UserRepository;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AuthForm());
		}
	}
}
