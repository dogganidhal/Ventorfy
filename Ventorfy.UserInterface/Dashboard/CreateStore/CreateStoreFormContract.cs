using System.Threading.Tasks;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.CreateStore
{
	public interface ICreateStoreFormView : IView
	{

	}

	public interface ICreateStoreFormPresenter : IPresenter<ICreateStoreFormView>
	{

		Task OnCreateStoreButtonClicked(string name);
		
	}
}
