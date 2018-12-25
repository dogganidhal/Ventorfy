using Ventorfy.UserInterface.Session;

namespace Ventorfy.UserInterface.Dashboard
{
	class DashboardFormPresenter : IDashboardFormPresenter
	{

		private IDashboardFormView _View;

		public void SetView(IDashboardFormView view)
		{
			this._View = view;
		}

		public void OnLogOutButtonClicked()
		{
			this._View.DisplayLogOutConfirmationDialog();
		}

		public void OnLogOutConfirm()
		{
			UserSession.Instance.CurrentUser = null;
			this._View.LaunchAuthFormView();
		}

	}
}
