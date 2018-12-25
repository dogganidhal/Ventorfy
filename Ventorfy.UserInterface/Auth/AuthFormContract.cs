using Ventorfy.UserInterface.MVP;
using Ventorfy.UserInterface.View;

namespace Ventorfy.UserInterface.Auth
{
	public interface IAuthFormView : IView
	{

		void DisplayError(string message);
		void DisplayLoginProgressBar();
		void HideLoginProgressBar();
		void DisplaySignUpProgressBar();
		void HideSignUpProgressBar();
		void LaunchDashboardForm();
		
	}

	public interface IAuthFormPresenter : IPresenter<AuthForm> 
	{

		void OnLoginButtonPressed(string userName, string passsword);
		void OnSignUpButtonPressed(string userName, string fullName, string password);

	}
}
