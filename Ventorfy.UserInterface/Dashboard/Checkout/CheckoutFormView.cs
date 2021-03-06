﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Repository;
using Ventorfy.UserInterface.Dashboard.AddOrderItem;

namespace Ventorfy.UserInterface.Dashboard.Checkout
{
	public partial class CheckoutFormView : Form, ICheckoutFormView
	{

		private ICheckoutFormPresenter _Presenter;
		private ICollection<Control> _HeaderControls = new List<Control>();

		public CheckoutFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
			this._SetUpView();
		}

		public void CreatePresenter()
		{
			this._Presenter = new CheckoutFormPresenter(RepositoryFactory.Instance.ClientOrderRepository);
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

			this.OrderItemsTableLayoutPanel.AutoSize = true;
			this.AddOrderItemButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnAddOrderItemButtonClicked();
			};
			this.SubmitOrderButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnSubmitOrderButtonClicked();
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

		public void FlushOrderItems()
		{
			this.OrderItemsTableLayoutPanel.Controls.Clear();
			foreach(var headerControl in this._HeaderControls)
			{
				this.OrderItemsTableLayoutPanel.Controls.Add(headerControl);
			}
		}

		private void OrderItemsTableLayoutPanel_Paint(object sender, PaintEventArgs e)
		{
			foreach(Control control in this.OrderItemsTableLayoutPanel.Controls)
			{
				if (control.Tag != null)
				{
					this._HeaderControls.Add(control);
				}
			}
		}
	}
}
