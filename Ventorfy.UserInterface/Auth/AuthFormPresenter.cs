using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventorfy.Common.Exceptions;
using Ventorfy.DataAccess.Repository.Users;
using Ventorfy.UserInterface.Auth;
using Ventorfy.UserInterface.Session;
using Ventorfy.UserInterface.View;

namespace Ventorfy.UserInterface.Presenter
{
	public class AuthFormPresenter : IAuthFormPresenter
	{

		private IAuthFormView _View;
		private readonly IUserRepository _UserRepository;

		public AuthFormPresenter(IUserRepository userRepository)
		{
			this._UserRepository = userRepository;
		}

		public async void OnLoginButtonPressed(string userName, string passsword)
		{

			this._View.DisplayLoginProgressBar();
			try
			{
				var user = await this._UserRepository.Login(userName, passsword);
				UserSession.Instance.CurrentUser = user;
				this._View.HideLoginProgressBar();
			} 
			catch (AccountNotFoundException e)
			{
				this._View.HideLoginProgressBar();
				this._View.DisplayError(e.Message);
			}

		}

		public async void OnSignUpButtonPressed(string userName, string fullName, string password)
		{

			this._View.DisplaySignUpProgressBar();
			try
			{
				var user = await this._UserRepository.CreateUser(userName, password, fullName);
				UserSession.Instance.CurrentUser = user;
				this._View.HideSignUpProgressBar();
			}
			catch (Exception e)
			{
				this._View.HideSignUpProgressBar();
				this._View.DisplayError(e.Message);
			}
			

		}

		public void SetView(AuthForm view)
		{
			this._View = view;
		}

	}
}
