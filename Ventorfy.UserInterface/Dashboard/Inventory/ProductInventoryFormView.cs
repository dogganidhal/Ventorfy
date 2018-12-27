using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ventorfy.DataAccess.Model.Products;

namespace Ventorfy.UserInterface.Dashboard.Inventory
{
	public partial class ProductInventoryFormView : Form, IProductInventoryFormView
	{

		private IProductInventoryFormPresenter _Presenter;

		public ProductInventoryFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
		}

		public void CreatePresenter()
		{
			throw new NotImplementedException();
		}

		public void LaunchAddProductDialog()
		{
			throw new NotImplementedException();
		}

		public void PopulateProducts(ICollection<Product> products)
		{
			throw new NotImplementedException();
		}
	}
}
