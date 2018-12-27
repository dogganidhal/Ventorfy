using System.Collections.Generic;
using Ventorfy.DataAccess.Model.Orders;
using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.Orders
{
	public interface IOrdersFormView : IView
	{

		void PopulateOrders(ICollection<ClientOrder> orders);

	}

	public interface IOrdersFormPresenter : IPresenter<IOrdersFormView>
	{

		void LoadData();

	}
}
