using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.Overview
{
	public interface IOverviewFormView : IView
	{

		

	}

	public interface IOverviewFormPresenter : IPresenter<IOverviewFormView>
	{

		void LoadData();

	}
}
