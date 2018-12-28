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

		public void PopulateProfitsProgress()
		{
			
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
			var earningsSeries = new Series
			{
				Name = "Earnings",
				Color = Color.Tomato,
				LegendText = "Earnings last week",
				ChartType = SeriesChartType.Line,
				XAxisType = AxisType.Primary
			};
			var spendingsSeries = new Series
			{
				Name = "Spendings",
				Color = Color.Blue,
				LegendText = "Spendings last week",
				ChartType = SeriesChartType.Line
			};
			
			spendingsSeries.Points.Add(new DataPoint(1, 10));
			spendingsSeries.Points.Add(new DataPoint(2, 13));
			spendingsSeries.Points.Add(new DataPoint(3, 9));
			spendingsSeries.Points.Add(new DataPoint(4, 12));
			spendingsSeries.Points.Add(new DataPoint(5, 8));
			spendingsSeries.Points.Add(new DataPoint(6, 10));
			spendingsSeries.Points.Add(new DataPoint(7, 11));

			earningsSeries.Points.Add(new DataPoint(1, 13));
			earningsSeries.Points.Add(new DataPoint(2, 12));
			earningsSeries.Points.Add(new DataPoint(3, 10));
			earningsSeries.Points.Add(new DataPoint(4, 10));
			earningsSeries.Points.Add(new DataPoint(5, 9));
			earningsSeries.Points.Add(new DataPoint(6, 11));
			earningsSeries.Points.Add(new DataPoint(7, 8));
			
			
			this.ProfitChart.Series.Clear();
			this.ProfitChart.Series.Add(earningsSeries);
			this.ProfitChart.Series.Add(spendingsSeries);

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
