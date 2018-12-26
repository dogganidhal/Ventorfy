using System.Collections.Generic;
using System.Linq;
using Ventorfy.DataAccess.Model.Orders;
using Ventorfy.DataAccess.Model.Products;

namespace Ventorfy.UserInterface.Dashboard.Checkout
{
	public class CheckoutFormPresenter : ICheckoutFormPresenter
	{

		private ICheckoutFormView _View;
		private readonly ICollection<OrderItem> _OrderItems = new List<OrderItem>();

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

	}
}
