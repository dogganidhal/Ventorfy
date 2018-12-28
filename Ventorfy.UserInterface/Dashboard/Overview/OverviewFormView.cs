using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Ventorfy.DataAccess.Model.Orders;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Model.Users;
using Ventorfy.DataAccess.Repository;
using Ventorfy.UserInterface.Dashboard.AddMember;

namespace Ventorfy.UserInterface.Dashboard.Overview
{
	public partial class OverviewFormView : Form, IOverviewFormView
	{

		private IOverviewFormPresenter _Presenter;

		public OverviewFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
			this._SetUpView();
		}

		public void AppendStaffMember(User member)
		{
			this.StaffMembersTablePanelLayout.Controls.Add(this._CreateLabel(member.UserName));
			this.StaffMembersTablePanelLayout.Controls.Add(this._CreateLabel(member.FullName));
		}

		public void CreatePresenter()
		{
			this._Presenter = new OverviewFormPresenter(
				orderRepository: RepositoryFactory.Instance.ClientOrderRepository,
				userRepository: RepositoryFactory.Instance.UserRepository,
				storeRepository: RepositoryFactory.Instance.StoreRepository,
				productRepository: RepositoryFactory.Instance.ProductRepository
			);
			this._Presenter.SetView(this);
			this._Presenter.LoadData();
		}

		public void LaunchAddStaffMemberDialog()
		{
			using (var addMemberFormView = new AddMemberFormView())
			{
				addMemberFormView.ShowDialog();
				this._Presenter.SubmitStaffMember(addMemberFormView.GetUserName(), addMemberFormView.GetFullName(), addMemberFormView.GetPassword());
			}
		}

		public void PopulateProfitsProgress(List<double> profits)
		{
			var earningsSeries = new Series
			{
				Name = "Earnings",
				Color = Color.Tomato,
				LegendText = "Last week profits",
				ChartType = SeriesChartType.Column,
				XAxisType = AxisType.Primary
			};

			for (var index = 0; index < 7; index++)
			{
				earningsSeries.Points.Add(new DataPoint(index + 1, profits[index]));
			}

			this.ProfitChart.Series.Clear();
			this.ProfitChart.Series.Add(earningsSeries);
		}

		public void PopulateRecentOrders(ICollection<ClientOrder> orders)
		{
			foreach(var order in orders)
			{
				var orderDate = $"{order.Date.ToShortDateString()} {order.Date.ToShortTimeString()}";
				this.RecentOrdersTablePanelLayout.Controls.Add(this._CreateLabel($"{orderDate} {order.ComputePrice()}$"));
			}
		}

		public void PopulateRecentProducts(ICollection<Product> products)
		{
			foreach (var product in products)
			{
				this.RecentProductsTablePanelLayout.Controls.Add(this._CreateLabel($"{product.Reference} ({product.Name})"));
			}
		}

		public void PopulateStaffMembers(ICollection<User> members)
		{
			foreach (var member in members)
			{
				this.StaffMembersTablePanelLayout.Controls.Add(this._CreateLabel(member.UserName));
				this.StaffMembersTablePanelLayout.Controls.Add(this._CreateLabel(member.FullName));
			}
		}

		private void _SetUpView()
		{

			this.AddStaffMemberButton.Click += (object @object, EventArgs args) =>
			{
				this._Presenter.OnAddStaffMemberButtonClicked();
			};
			

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
