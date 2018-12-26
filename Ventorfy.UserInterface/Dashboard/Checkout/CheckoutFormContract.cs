using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.Checkout
{
	public interface ICheckoutFormView : IView
	{

		void LaunchSelectOrderItemDialog();

	}

	public interface ICheckoutFormPresenter : IPresenter<ICheckoutFormView>
	{

		void OnAddOrderItemButtonClicked();

	}
}
