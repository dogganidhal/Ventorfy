using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventorfy.UserInterface.Dashboard.Checkout
{
	public class CheckoutFormPresenter : ICheckoutFormPresenter
	{

		private ICheckoutFormView _View;

		public void OnAddOrderItemButtonClicked()
		{
			this._View.LaunchSelectOrderItemDialog();
		}

		public void SetView(ICheckoutFormView view)
		{
			this._View = view;
		}

	}
}
