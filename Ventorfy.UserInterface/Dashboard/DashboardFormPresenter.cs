using Ventorfy.DataAccess.Repository.Inventory;
using Ventorfy.UserInterface.Session;

namespace Ventorfy.UserInterface.Dashboard
{
	class DashboardFormPresenter : IDashboardFormPresenter
	{

		private IDashboardFormView _View;

		public DashboardFormPresenter()
		{
		}

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
			UserSession.Instance.SetCurrentUser(null);
			this._View.LaunchAuthFormView();
		}

		public void LoadData()
		{
			var currentUser = UserSession.Instance.GetCurrentUser();
			this._View.SetUserFullName(currentUser?.FullName);
			this._View.SetStoreName(currentUser?.Store?.Name);
			if (currentUser?.Store == null)
			{
				this._View.DisplayCreateStoreForm();
			}
			this._View.SetOverviewFormSelected();
		}

		public void OnOverviewButtonClicked()
		{
			this._View.SetOverviewFormSelected();
		}

		public void OnInventoryButtonClicked()
		{
			this._View.SetInventoryFormSelected();
		}

		public void OnCheckoutButtonClicked()
		{
			this._View.SetCheckoutFormSelected();
		}

		public void OnOrdersButtonClicked()
		{
			this._View.SetOrdersFormSelected();
		}
	}
}
