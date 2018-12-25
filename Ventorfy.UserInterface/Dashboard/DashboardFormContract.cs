using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard
{
	public interface IDashboardFormView : IView
	{

		void DisplayLogOutConfirmationDialog();
		void LaunchAuthFormView();

	}

	public interface IDashboardFormPresenter : IPresenter<IDashboardFormView>
	{

		void OnLogOutButtonClicked();
		void OnLogOutConfirm();

	}
}
