namespace Ventorfy.UserInterface.Dashboard.Overview
{
	partial class OverviewFormView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
			this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
			this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
			this.ProfitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.NewestProductsCard = new Bunifu.Framework.UI.BunifuCards();
			this.label2 = new System.Windows.Forms.Label();
			this.RecentProductsTablePanelLayout = new System.Windows.Forms.TableLayoutPanel();
			this.RecentOrdersTablePanelLayout = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.StaffMembersTablePanelLayout = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.bunifuCards3.SuspendLayout();
			this.bunifuCards2.SuspendLayout();
			this.bunifuCards1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProfitChart)).BeginInit();
			this.NewestProductsCard.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.bunifuCards3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.bunifuCards2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.bunifuCards1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.NewestProductsCard, 1, 0);
			this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 501);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// bunifuCards3
			// 
			this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
			this.bunifuCards3.BorderRadius = 5;
			this.bunifuCards3.BottomSahddow = true;
			this.bunifuCards3.color = System.Drawing.Color.Tomato;
			this.bunifuCards3.Controls.Add(this.StaffMembersTablePanelLayout);
			this.bunifuCards3.Controls.Add(this.label3);
			this.bunifuCards3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuCards3.LeftSahddow = false;
			this.bunifuCards3.Location = new System.Drawing.Point(3, 253);
			this.bunifuCards3.Name = "bunifuCards3";
			this.bunifuCards3.RightSahddow = true;
			this.bunifuCards3.ShadowDepth = 20;
			this.bunifuCards3.Size = new System.Drawing.Size(389, 245);
			this.bunifuCards3.TabIndex = 3;
			// 
			// bunifuCards2
			// 
			this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
			this.bunifuCards2.BorderRadius = 5;
			this.bunifuCards2.BottomSahddow = true;
			this.bunifuCards2.color = System.Drawing.Color.Tomato;
			this.bunifuCards2.Controls.Add(this.RecentOrdersTablePanelLayout);
			this.bunifuCards2.Controls.Add(this.label1);
			this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuCards2.LeftSahddow = false;
			this.bunifuCards2.Location = new System.Drawing.Point(398, 253);
			this.bunifuCards2.Name = "bunifuCards2";
			this.bunifuCards2.RightSahddow = true;
			this.bunifuCards2.ShadowDepth = 20;
			this.bunifuCards2.Size = new System.Drawing.Size(390, 245);
			this.bunifuCards2.TabIndex = 2;
			// 
			// bunifuCards1
			// 
			this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
			this.bunifuCards1.BorderRadius = 5;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = System.Drawing.Color.Tomato;
			this.bunifuCards1.Controls.Add(this.tableLayoutPanel2);
			this.bunifuCards1.Controls.Add(this.label4);
			this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new System.Drawing.Point(3, 3);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new System.Drawing.Size(389, 244);
			this.bunifuCards1.TabIndex = 1;
			// 
			// ProfitChart
			// 
			chartArea6.Name = "ChartArea1";
			this.ProfitChart.ChartAreas.Add(chartArea6);
			this.ProfitChart.Dock = System.Windows.Forms.DockStyle.Fill;
			legend6.Name = "Legend1";
			this.ProfitChart.Legends.Add(legend6);
			this.ProfitChart.Location = new System.Drawing.Point(3, 3);
			this.ProfitChart.Name = "ProfitChart";
			this.ProfitChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series6.ChartArea = "ChartArea1";
			series6.Legend = "Legend1";
			series6.Name = "Series1";
			this.ProfitChart.Series.Add(series6);
			this.ProfitChart.Size = new System.Drawing.Size(381, 205);
			this.ProfitChart.TabIndex = 1;
			this.ProfitChart.Text = "chart1";
			// 
			// NewestProductsCard
			// 
			this.NewestProductsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
			this.NewestProductsCard.BorderRadius = 5;
			this.NewestProductsCard.BottomSahddow = true;
			this.NewestProductsCard.color = System.Drawing.Color.Tomato;
			this.NewestProductsCard.Controls.Add(this.RecentProductsTablePanelLayout);
			this.NewestProductsCard.Controls.Add(this.label2);
			this.NewestProductsCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NewestProductsCard.LeftSahddow = false;
			this.NewestProductsCard.Location = new System.Drawing.Point(398, 3);
			this.NewestProductsCard.Name = "NewestProductsCard";
			this.NewestProductsCard.RightSahddow = true;
			this.NewestProductsCard.ShadowDepth = 20;
			this.NewestProductsCard.Size = new System.Drawing.Size(390, 244);
			this.NewestProductsCard.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Location = new System.Drawing.Point(0, 5);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 25);
			this.label2.TabIndex = 5;
			this.label2.Tag = "1001";
			this.label2.Text = "Recenly Added Products";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RecentProductsTablePanelLayout
			// 
			this.RecentProductsTablePanelLayout.ColumnCount = 1;
			this.RecentProductsTablePanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.RecentProductsTablePanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RecentProductsTablePanelLayout.Location = new System.Drawing.Point(0, 30);
			this.RecentProductsTablePanelLayout.Name = "RecentProductsTablePanelLayout";
			this.RecentProductsTablePanelLayout.RowCount = 6;
			this.RecentProductsTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentProductsTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentProductsTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentProductsTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentProductsTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentProductsTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentProductsTablePanelLayout.Size = new System.Drawing.Size(388, 211);
			this.RecentProductsTablePanelLayout.TabIndex = 6;
			// 
			// RecentOrdersTablePanelLayout
			// 
			this.RecentOrdersTablePanelLayout.ColumnCount = 1;
			this.RecentOrdersTablePanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.RecentOrdersTablePanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RecentOrdersTablePanelLayout.Location = new System.Drawing.Point(0, 30);
			this.RecentOrdersTablePanelLayout.Name = "RecentOrdersTablePanelLayout";
			this.RecentOrdersTablePanelLayout.RowCount = 6;
			this.RecentOrdersTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentOrdersTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentOrdersTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentOrdersTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentOrdersTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentOrdersTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.RecentOrdersTablePanelLayout.Size = new System.Drawing.Size(388, 212);
			this.RecentOrdersTablePanelLayout.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(0, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 25);
			this.label1.TabIndex = 7;
			this.label1.Tag = "1001";
			this.label1.Text = "Recent Orders";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StaffMembersTablePanelLayout
			// 
			this.StaffMembersTablePanelLayout.ColumnCount = 2;
			this.StaffMembersTablePanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.StaffMembersTablePanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.StaffMembersTablePanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffMembersTablePanelLayout.Location = new System.Drawing.Point(0, 30);
			this.StaffMembersTablePanelLayout.Name = "StaffMembersTablePanelLayout";
			this.StaffMembersTablePanelLayout.RowCount = 1;
			this.StaffMembersTablePanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.StaffMembersTablePanelLayout.Size = new System.Drawing.Size(387, 212);
			this.StaffMembersTablePanelLayout.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(0, 5);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 25);
			this.label3.TabIndex = 9;
			this.label3.Tag = "1001";
			this.label3.Text = "Staff Members";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label4.Location = new System.Drawing.Point(0, 5);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 25);
			this.label4.TabIndex = 6;
			this.label4.Tag = "1001";
			this.label4.Text = "Profits Progress";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.ProfitChart, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 211);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// OverviewFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(791, 501);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OverviewFormView";
			this.Text = "OverviewFormView";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.bunifuCards3.ResumeLayout(false);
			this.bunifuCards3.PerformLayout();
			this.bunifuCards2.ResumeLayout(false);
			this.bunifuCards2.PerformLayout();
			this.bunifuCards1.ResumeLayout(false);
			this.bunifuCards1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProfitChart)).EndInit();
			this.NewestProductsCard.ResumeLayout(false);
			this.NewestProductsCard.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Bunifu.Framework.UI.BunifuCards bunifuCards2;
		private Bunifu.Framework.UI.BunifuCards bunifuCards1;
		private Bunifu.Framework.UI.BunifuCards bunifuCards3;
		private Bunifu.Framework.UI.BunifuCards NewestProductsCard;
		private System.Windows.Forms.DataVisualization.Charting.Chart ProfitChart;
		private System.Windows.Forms.TableLayoutPanel StaffMembersTablePanelLayout;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel RecentOrdersTablePanelLayout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel RecentProductsTablePanelLayout;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}