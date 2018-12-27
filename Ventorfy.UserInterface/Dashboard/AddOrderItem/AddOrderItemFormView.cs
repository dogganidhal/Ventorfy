using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Repository;

namespace Ventorfy.UserInterface.Dashboard.AddOrderItem
{
	public partial class AddOrderItemFormView : Form, IAddOrderItemFormView
	{

		private IAddOrderItemFormPresenter _Presenter;

		public AddOrderItemFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
			this.OkButton.Click += (object @object, EventArgs args) =>
			{
				this.DialogResult = DialogResult.OK;
				this.Hide();
			};
		}

		public void CreatePresenter()
		{
			this._Presenter = new AddOrderItemPresenter(RepositoryFactory.Instance.ProductRepository);
			this._Presenter.SetView(this);
			this._Presenter.LoadData();
		}

		public int GetItemCount()
		{
			return int.Parse(this.ItemCountTextBox.Text);
		}

		public Product GetSelectedProduct()
		{
			return this._Presenter.GetProductAtIndex(this.ProductsListBox.SelectedIndex);
		}

		public void PopulateProducts(ICollection<Product> products)
		{
			this.ProductsListBox.DataSource = null;
			this.ProductsListBox.DataSource = products.Select(product => $"{product.Reference} ({product.Name})").ToList();
		}

	}
}
