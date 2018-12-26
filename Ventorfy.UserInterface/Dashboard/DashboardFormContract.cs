using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard
{
	public interface IDashboardFormView : IView
	{

		void DisplayLogOutConfirmationDialog();
		void LaunchAuthFormView();
		void SetUserFullName(string fullName);
		void SetStoreName(string storeName);
		void DisplayCreateStoreForm();
		void SetOverviewFormSelected();
		void SetInventoryFormSelected();
		void SetCheckoutFormSelected();
		void SetOrderFormSelected();

	}

	public interface IDashboardFormPresenter : IPresenter<IDashboardFormView>
	{

		void OnLogOutButtonClicked();
		void OnLogOutConfirm();
		void LoadData();
		void OnOverviewButtonClicked();
		void OnInventoryButtonClicked();
		void OnCheckoutButtonClicked();
		void OnOrdersButtonClicked();

	}
}
