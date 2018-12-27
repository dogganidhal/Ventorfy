
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.Checkout
{
	public interface ICheckoutFormView : IView
	{

		void LaunchSelectOrderItemDialog();
		void SetTotalPrice(double totalPrice);
		void SetTotalItems(int items);
		void FlushOrderItems();

	}

	public interface ICheckoutFormPresenter : IPresenter<ICheckoutFormView>
	{

		void OnAddOrderItemButtonClicked();
		void OnOrderItemAdded(Product product, int count);
		void OnSubmitOrderButtonClicked();

	}
}
