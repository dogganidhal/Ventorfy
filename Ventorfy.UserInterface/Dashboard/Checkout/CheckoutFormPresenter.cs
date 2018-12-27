using System.Collections.Generic;
using System.Linq;
using Ventorfy.DataAccess.Model.Orders;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Repository.Orders;
using Ventorfy.UserInterface.Session;

namespace Ventorfy.UserInterface.Dashboard.Checkout
{
	public class CheckoutFormPresenter : ICheckoutFormPresenter
	{

		private ICheckoutFormView _View;
		private IList<OrderItem> _OrderItems = new List<OrderItem>();
		private IClientOrderRepository _OrderRepository;

		public CheckoutFormPresenter(IClientOrderRepository orderRepository)
		{
			this._OrderRepository = orderRepository;
		}

		public void OnAddOrderItemButtonClicked()
		{
			this._View.LaunchSelectOrderItemDialog();
		}

		public void OnOrderItemAdded(Product product, int count)
		{
			this._OrderItems.Add(new OrderItem(product, count));
			this._View.SetTotalPrice(this._OrderItems.Sum(orderItem => orderItem.Product.Price * orderItem.Count));
			this._View.SetTotalItems(this._OrderItems.Sum(orderItem => orderItem.Count));
		}

		public void SetView(ICheckoutFormView view)
		{
			this._View = view;
		}

		public async void OnSubmitOrderButtonClicked()
		{
			var userId = UserSession.Instance.GetCurrentUser().Id;
			var orderItems = await this._OrderRepository.CreateOrderItems(this._OrderItems);
			var order = await this._OrderRepository.SubmitClientOrder(userId, orderItems);
			this._View.FlushOrderItems();
			this._View.SetTotalItems(0);
			this._View.SetTotalPrice(0.0);
		}
	}
}
