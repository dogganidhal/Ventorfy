using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventorfy.DataAccess.Repository;
using Ventorfy.DataAccess.Repository.Users;

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
			Application.Run(new Form1());
		}
	}
}
