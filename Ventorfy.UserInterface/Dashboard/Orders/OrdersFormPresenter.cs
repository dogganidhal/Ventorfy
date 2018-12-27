using Ventorfy.DataAccess.Repository.Orders;
using Ventorfy.UserInterface.Session;

namespace Ventorfy.UserInterface.Dashboard.Orders
{
	class OrdersFormPresenter : IOrdersFormPresenter
	{
		
		private IOrdersFormView _View;
		private IClientOrderRepository _OrderRepository;

		public OrdersFormPresenter(IClientOrderRepository orderRepository)
		{
			this._OrderRepository = orderRepository;
		}

		public async void LoadData()
		{
			var storeId = UserSession.Instance.GetCurrentUser().Store.Id;
			var orders = await this._OrderRepository.SelectOrders(storeId, (_) => true);
			this._View.PopulateOrders(orders);
		}

		public void SetView(IOrdersFormView view)
		{
			this._View = view;
		}
	}
}
