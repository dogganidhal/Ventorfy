using System;
using System.Windows.Forms;
using Ventorfy.DataAccess.Repository;

namespace Ventorfy.UserInterface.Dashboard.AddProduct
{
	public partial class AddProductFormView : Form, IAddProductFormView
	{

		private IAddProductFormPresenter _Presenter;

		public AddProductFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
		}

		public void CreatePresenter()
		{
			this._Presenter = new AddProductFormPresenter(RepositoryFactory.Instance.ProductRepository);
			this._Presenter.SetView(this);
			this._Presenter.LoadData();
		}

		public double GetPrice()
		{
			throw new NotImplementedException();
		}

		public string GetProductCategoryName()
		{
			throw new NotImplementedException();
		}

		public string GetProductName()
		{
			throw new NotImplementedException();
		}

		public string GetProductReference()
		{
			throw new NotImplementedException();
		}
	}
}
