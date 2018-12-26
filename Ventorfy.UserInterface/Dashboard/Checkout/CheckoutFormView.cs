using System;
using System.Drawing;
using System.Windows.Forms;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.UserInterface.Dashboard.AddOrderItem;

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
			this._Presenter.SetView(this);
		}

		public void LaunchSelectOrderItemDialog()
		{
			using (var addOrderItemFormView = new AddOrderItemFormView())
			{
				addOrderItemFormView.ShowDialog();
				var product = addOrderItemFormView.GetSelectedProduct();
				var count = addOrderItemFormView.GetItemCount();
				this._Presenter.OnOrderItemAdded(product, count);
				this._AddOrderItemRow(product, count);
			}
		}

		public void SetTotalItems(int items)
		{
			this.OrderItemTotalLabel.Text = $"TOTAL ARTICLES : {items}";
		}

		public void SetTotalPrice(double totalPrice)
		{
			this.TotalPriceLabel.Text = $"TOTAL PRICE : {totalPrice}$";
		}

		private void _SetUpView()
		{
		
			this.AddOrderItemButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnAddOrderItemButtonClicked();
			};
			
		}

		private void _AddOrderItemRow(Product product, int count)
		{
			this.OrderItemsTableLayoutPanel.Controls.Add(this._CreateLabel(product.Name));
			this.OrderItemsTableLayoutPanel.Controls.Add(this._CreateLabel(product.Reference));
			this.OrderItemsTableLayoutPanel.Controls.Add(this._CreateLabel(count.ToString()));
			this.OrderItemsTableLayoutPanel.Controls.Add(this._CreateLabel(product.Price.ToString()));
		}

		private Label _CreateLabel(string text)
		{
			var font = new Font(FontFamily.GenericSansSerif, 14);
			var label = new Label()
			{
				Text = text,
				Font = font,
				ForeColor = Color.WhiteSmoke
			};
			return label;
		}

	}
}
