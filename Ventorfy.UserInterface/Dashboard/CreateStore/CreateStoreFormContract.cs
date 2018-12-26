using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.CreateStore
{
	public interface ICreateStoreFormView : IView
	{

		void Destroy();

	}

	public interface ICreateStoreFormPresenter : IPresenter<ICreateStoreFormView>
	{

		void OnCreateStoreButtonClicked(string name);
		
	}
}
