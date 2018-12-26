using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

		public void CreatePresenter()
		{
			this._Presenter = new OverviewFormPresenter();
			this._Presenter.SetView(this);
			this._Presenter.LoadData();
		}

		private void _SetUpView()
		{

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


	}
}
