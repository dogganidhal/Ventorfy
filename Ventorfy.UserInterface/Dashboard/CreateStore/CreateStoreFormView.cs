using System;
using System.Windows.Forms;
using Ventorfy.DataAccess.Repository;

namespace Ventorfy.UserInterface.Dashboard.CreateStore
{
	public partial class CreateStoreFormView : Form, ICreateStoreFormView
	{

		private ICreateStoreFormPresenter _Presenter;

		public CreateStoreFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
			this._SetUpView();
		}

		public void CreatePresenter()
		{
			this._Presenter = new CreateStoreFormPresenter(RepositoryFactory.Instance.StoreRepository);
			this._Presenter.SetView(this);
		}

		public void Destroy()
		{
			this.Close();
		}

		private void _SetUpView()
		{
			this.CreateButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnCreateStoreButtonClicked(this.StoreNameTextBox.Text);
			};
		}

	}
}
