using Ventorfy.DataAccess.Repository.Inventory;
using Ventorfy.UserInterface.Session;

namespace Ventorfy.UserInterface.Dashboard.CreateStore
{
	class CreateStoreFormPresenter : ICreateStoreFormPresenter
	{

		private ICreateStoreFormView _View;
		private IStoreRepository _StoreRepository;

		public CreateStoreFormPresenter(IStoreRepository storeRepository)
		{
			this._StoreRepository = storeRepository;
		}

		public async void OnCreateStoreButtonClicked(string name)
		{
			var currentUser = UserSession.Instance.GetCurrentUser();
			var store = await this._StoreRepository.CreateStore(currentUser, name);
			currentUser.Store = store;
			this._View.Destroy();
		}

		public void SetView(ICreateStoreFormView view)
		{
			this._View = view;
		}
	}
}
