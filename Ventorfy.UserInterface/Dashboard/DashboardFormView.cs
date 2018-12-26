using System;
using System.Windows.Forms;
using Ventorfy.UserInterface.Auth;
using Ventorfy.UserInterface.Dashboard.Checkout;
using Ventorfy.UserInterface.Dashboard.CreateStore;
using Ventorfy.UserInterface.Dashboard.Overview;

namespace Ventorfy.UserInterface.Dashboard
{
	public partial class DashboardFormView : Form, IDashboardFormView
	{

		private IDashboardFormPresenter _Presenter;
		private OverviewFormView _OverviewFormView = new OverviewFormView();
		private CheckoutFormView _CheckoutFormView = new CheckoutFormView(); 

		public DashboardFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
			this._SetUpView();
		}

		public void CreatePresenter()
		{
			this._Presenter = new DashboardFormPresenter();
			this._Presenter.SetView(this);
			this._Presenter.LoadData();
		}

		public void DisplayCreateStoreForm()
		{
			var storeFormView = new CreateStoreFormView();
			storeFormView.Show();
			storeFormView.BringToFront();
		}

		public void DisplayLogOutConfirmationDialog()
		{
			var dialogResult = MessageBox.Show("Are you sure you want to log out?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult == DialogResult.Yes)
			{
				this._Presenter.OnLogOutConfirm();
			}
		}

		public void LaunchAuthFormView()
		{
			var authFormView = new AuthFormView();
			authFormView.Show();
			this.Close();
		}

		public void SetCheckoutFormSelected()
		{
			this._CheckoutFormView.Show();
			this._CheckoutFormView.BringToFront();
		}

		public void SetOverviewFormSelected()
		{
			this._OverviewFormView.Show();
			this._OverviewFormView.BringToFront();
		}

		public void SetInventoryFormSelected()
		{
			throw new NotImplementedException();
		}

		public void SetOrderFormSelected()
		{
			throw new NotImplementedException();
		}

		public void SetStoreName(string storeName)
		{
			this.StoreNameLabel.Text = storeName;
		}

		public void SetUserFullName(string fullName)
		{
			this.UserFullNameLabel.Text = fullName;
		}

		private void _SetUpView()
		{
			
			this._CheckoutFormView.TopLevel = false;
			this._CheckoutFormView.Dock = DockStyle.Fill;
			this.ContainerPanel.Controls.Add(this._CheckoutFormView);

			this._OverviewFormView.TopLevel = false;
			this._OverviewFormView.Dock = DockStyle.Fill;
			this.ContainerPanel.Controls.Add(this._OverviewFormView);

			this.LogOutButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnLogOutButtonClicked();
			};
			this.CheckoutButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnCheckoutButtonClicked();
			};
		}
	}
}
