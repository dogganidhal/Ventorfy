using System;
using System.Windows.Forms;

namespace Ventorfy.UserInterface.Dashboard.Checkout
{
	public partial class CheckoutFormView : Form, ICheckoutFormView
	{

		private ICheckoutFormPresenter _Presenter;

		public CheckoutFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
			this._SetUpView();
		}

		public void CreatePresenter()
		{
			this._Presenter = new CheckoutFormPresenter();
		}

		public void LaunchSelectOrderItemDialog()
		{
			
		}

		private void _SetUpView()
		{
		
			this.AddOrderItemButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnAddOrderItemButtonClicked();
			};


		}
	}
}
