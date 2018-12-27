using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ventorfy.DataAccess.Model.Orders;
using Ventorfy.DataAccess.Repository;

namespace Ventorfy.UserInterface.Dashboard.Orders
{
	public partial class OrdersFormView : Form, IOrdersFormView
	{

		private IOrdersFormPresenter _Presenter;

		public OrdersFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
		}

		public void CreatePresenter()
		{
			this._Presenter = new OrdersFormPresenter(RepositoryFactory.Instance.ClientOrderRepository);
			this._Presenter.SetView(this);
			this._Presenter.LoadData();
		}

		public void PopulateOrders(ICollection<ClientOrder> orders)
		{
			foreach(var order in orders)
			{
				var itemCount = order.Items?.Sum(item => item.Count) * order.Items?.Count ?? 0;
				this.OrdersTableLayoutPanel.Controls.Add(this._CreateLabel(order.Date.ToString("dd-MM-yyyy hh:mm")));
				this.OrdersTableLayoutPanel.Controls.Add(this._CreateLabel(order.Author.FullName));
				this.OrdersTableLayoutPanel.Controls.Add(this._CreateLabel(itemCount.ToString()));
				this.OrdersTableLayoutPanel.Controls.Add(this._CreateLabel($"{order.ComputePrice()} $"));
			}
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

	}
}
