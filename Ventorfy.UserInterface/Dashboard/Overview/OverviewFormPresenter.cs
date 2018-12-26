

namespace Ventorfy.UserInterface.Dashboard.Overview
{
	class OverviewFormPresenter : IOverviewFormPresenter
	{

		private IOverviewFormView _View;

		public void SetView(IOverviewFormView view)
		{
			this._View = view;
		}

		public void LoadData()
		{
			
		}

	}
}
