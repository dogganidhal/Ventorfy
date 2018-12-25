namespace Ventorfy.UserInterface.Dashboard
{
	class DashboardFormPresenter : IDashboardFormPresenter
	{

		private IDashboardFormView _View;

		public void SetView(IDashboardFormView view)
		{
			this._View = view;
		}

	}
}
