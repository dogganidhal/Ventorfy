using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Repository;
using Ventorfy.UserInterface.Dashboard.AddProduct;

namespace Ventorfy.UserInterface.Dashboard.Inventory
{
	public partial class ProductInventoryFormView : Form, IProductInventoryFormView
	{

		private IProductInventoryFormPresenter _Presenter;

		public ProductInventoryFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
			this._SetUpView();
		}

		public void CreatePresenter()
		{
			this._Presenter = new ProductInventoryFormPresenter(RepositoryFactory.Instance.ProductRepository);
			this._Presenter.SetView(this);
			this._Presenter.LoadData();
		}

		public void LaunchAddProductDialog()
		{
			using (var addProductFormView = new AddProductFormView())
			{
				addProductFormView.ShowDialog();
				var productName = addProductFormView.GetProductName();
				var productCategoryName = addProductFormView.GetProductCategoryName();
				var productReference = addProductFormView.GetProductReference();
				var productUnitPrice = addProductFormView.GetPrice();
				var quantity = addProductFormView.GetQuantity();
				this._Presenter.OnAddProductSubmit(productReference, productUnitPrice, productCategoryName, quantity, productName);
			}
		}

		public void PopulateProducts(ICollection<Product> products)
		{
			foreach (var product in products)
			{
				this.ProductsTableLayoutPanel.Controls.Add(this._CreateLabel(product.Name));
				this.ProductsTableLayoutPanel.Controls.Add(this._CreateLabel(product.Reference));
				this.ProductsTableLayoutPanel.Controls.Add(this._CreateLabel(product.ProductLot.Quantity.ToString()));
				this.ProductsTableLayoutPanel.Controls.Add(this._CreateLabel(product.Price.ToString()));
			}
		}

		public void AppendToProductList(Product product)
		{
			this.ProductsTableLayoutPanel.Controls.Add(this._CreateLabel(product.Name));
			this.ProductsTableLayoutPanel.Controls.Add(this._CreateLabel(product.Reference));
			this.ProductsTableLayoutPanel.Controls.Add(this._CreateLabel(product.ProductLot.Quantity.ToString()));
			this.ProductsTableLayoutPanel.Controls.Add(this._CreateLabel(product.Price.ToString()));
		}

		private Label _CreateLabel(string text)
		{
			var font = new Font(FontFamily.GenericSansSerif, 12);
			var label = new Label()
			{
				Text = text,
				Font = font,
				ForeColor = Color.WhiteSmoke,
				TextAlign = ContentAlignment.MiddleCenter
			};
			label.Dock = DockStyle.Fill;
			label.Margin = new Padding() { Top = 8 };
			return label;
		}

		private void _SetUpView()
		{
			this.ProductsTableLayoutPanel.AutoSize = true;
			this.AddProductButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnAddProductButtonClicked();
			};
		}

	}
}
