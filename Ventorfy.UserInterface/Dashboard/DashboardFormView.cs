using System;
using System.Windows.Forms;
using Ventorfy.UserInterface.Auth;
using Ventorfy.UserInterface.Dashboard.Checkout;
using Ventorfy.UserInterface.Dashboard.CreateStore;
using Ventorfy.UserInterface.Dashboard.Inventory;
using Ventorfy.UserInterface.Dashboard.Overview;

namespace Ventorfy.UserInterface.Dashboard
{
	public partial class DashboardFormView : Form, IDashboardFormView
	{

		private IDashboardFormPresenter _Presenter;
		private Form _SelectedForm;

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
			this._SetSelectedForm(new CheckoutFormView());
		}

		public void SetOverviewFormSelected()
		{
			this._SetSelectedForm(new OverviewFormView());
		}

		public void SetInventoryFormSelected()
		{
			this._SetSelectedForm(new ProductInventoryFormView());
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

		private void _SetSelectedForm(Form form)
		{
			this.Controls.Remove(this._SelectedForm);
			this._SelectedForm?.Dispose();
			this._SelectedForm = form;
			this._SelectedForm.TopLevel = false;
			this._SelectedForm.Dock = DockStyle.Fill;
			this.ContainerPanel.Controls.Add(this._SelectedForm);
			this._SelectedForm.Show();
		}

		private void _SetUpView()
		{
		
			this.LogOutButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnLogOutButtonClicked();
			};
			this.DashboardButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnOverviewButtonClicked();
			};
			this.CheckoutButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnCheckoutButtonClicked();
			};
			this.InventoryButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnInventoryButtonClicked();
			};
		}
	}
}
