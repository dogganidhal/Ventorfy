using System;
using System.Windows.Forms;

namespace Ventorfy.UserInterface.Dashboard.AddProduct
{
	public partial class AddProductFormView : Form, IAddProductFormView
	{

		private IAddProductFormPresenter _Presenter;

		public AddProductFormView()
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
			this._Presenter = new AddProductFormPresenter();
			this._Presenter.SetView(this);
		}

		public double GetPrice()
		{
			return double.Parse(this.UnitPriceTextBox.Text);
		}

		public string GetProductCategoryName()
		{
			return this.CategoryNameTextBox.Text;
		}

		public string GetProductName()
		{
			return this.ProductNameTextBox.Text;
		}

		public string GetProductReference()
		{
			return this.ProductReferenceTextBox.Text;
		}

		public int GetQuantity()
		{
			return int.Parse(this.QuantityTextBox.Text);
		}

	}
}
