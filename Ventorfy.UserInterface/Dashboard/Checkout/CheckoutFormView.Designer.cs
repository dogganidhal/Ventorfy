namespace Ventorfy.UserInterface.Dashboard.Checkout
{
	partial class CheckoutFormView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutFormView));
			this.OrderItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AddOrderItemButton = new Bunifu.Framework.UI.BunifuTileButton();
			this.OrderItemTotalLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.TotalPriceLabel = new System.Windows.Forms.Label();
			this.SubmitOrderButton = new Bunifu.Framework.UI.BunifuTileButton();
			this.OrderItemsTableLayoutPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// OrderItemsTableLayoutPanel
			// 
			this.OrderItemsTableLayoutPanel.ColumnCount = 4;
			this.OrderItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.OrderItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.OrderItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.OrderItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.OrderItemsTableLayoutPanel.Controls.Add(this.label4, 0, 0);
			this.OrderItemsTableLayoutPanel.Controls.Add(this.label3, 0, 0);
			this.OrderItemsTableLayoutPanel.Controls.Add(this.label1, 0, 0);
			this.OrderItemsTableLayoutPanel.Controls.Add(this.label2, 0, 0);
			this.OrderItemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.OrderItemsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.OrderItemsTableLayoutPanel.Name = "OrderItemsTableLayoutPanel";
			this.OrderItemsTableLayoutPanel.RowCount = 1;
			this.OrderItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.OrderItemsTableLayoutPanel.Size = new System.Drawing.Size(800, 64);
			this.OrderItemsTableLayoutPanel.TabIndex = 0;
			this.OrderItemsTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OrderItemsTableLayoutPanel_Paint);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label4.Location = new System.Drawing.Point(403, 16);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 25);
			this.label4.TabIndex = 7;
			this.label4.Tag = "1002";
			this.label4.Text = "Count";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(603, 16);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 25);
			this.label3.TabIndex = 6;
			this.label3.Tag = "1003";
			this.label3.Text = "Unit price";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(3, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 25);
			this.label1.TabIndex = 5;
			this.label1.Tag = "1000";
			this.label1.Text = "Product name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Location = new System.Drawing.Point(203, 16);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 25);
			this.label2.TabIndex = 4;
			this.label2.Tag = "1001";
			this.label2.Text = "Reference";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AddOrderItemButton
			// 
			this.AddOrderItemButton.BackColor = System.Drawing.Color.Transparent;
			this.AddOrderItemButton.color = System.Drawing.Color.Transparent;
			this.AddOrderItemButton.colorActive = System.Drawing.Color.Transparent;
			this.AddOrderItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddOrderItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.AddOrderItemButton.ForeColor = System.Drawing.Color.White;
			this.AddOrderItemButton.Image = ((System.Drawing.Image)(resources.GetObject("AddOrderItemButton.Image")));
			this.AddOrderItemButton.ImagePosition = 20;
			this.AddOrderItemButton.ImageZoom = 40;
			this.AddOrderItemButton.LabelPosition = 41;
			this.AddOrderItemButton.LabelText = "ADD ITEM";
			this.AddOrderItemButton.Location = new System.Drawing.Point(6, 6);
			this.AddOrderItemButton.Margin = new System.Windows.Forms.Padding(6);
			this.AddOrderItemButton.Name = "AddOrderItemButton";
			this.AddOrderItemButton.Size = new System.Drawing.Size(128, 129);
			this.AddOrderItemButton.TabIndex = 1;
			// 
			// OrderItemTotalLabel
			// 
			this.OrderItemTotalLabel.AutoSize = true;
			this.OrderItemTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OrderItemTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OrderItemTotalLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.OrderItemTotalLabel.Location = new System.Drawing.Point(143, 0);
			this.OrderItemTotalLabel.Name = "OrderItemTotalLabel";
			this.OrderItemTotalLabel.Size = new System.Drawing.Size(178, 141);
			this.OrderItemTotalLabel.TabIndex = 2;
			this.OrderItemTotalLabel.Text = "TOTAL ARTICLES : 0";
			this.OrderItemTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.AddOrderItemButton);
			this.flowLayoutPanel1.Controls.Add(this.OrderItemTotalLabel);
			this.flowLayoutPanel1.Controls.Add(this.TotalPriceLabel);
			this.flowLayoutPanel1.Controls.Add(this.SubmitOrderButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 397);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 135);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// TotalPriceLabel
			// 
			this.TotalPriceLabel.AutoSize = true;
			this.TotalPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TotalPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalPriceLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.TotalPriceLabel.Location = new System.Drawing.Point(327, 0);
			this.TotalPriceLabel.Name = "TotalPriceLabel";
			this.TotalPriceLabel.Size = new System.Drawing.Size(158, 141);
			this.TotalPriceLabel.TabIndex = 3;
			this.TotalPriceLabel.Text = "TOTAL PRICE : 0$";
			this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SubmitOrderButton
			// 
			this.SubmitOrderButton.BackColor = System.Drawing.Color.Transparent;
			this.SubmitOrderButton.color = System.Drawing.Color.Transparent;
			this.SubmitOrderButton.colorActive = System.Drawing.Color.Transparent;
			this.SubmitOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SubmitOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.SubmitOrderButton.ForeColor = System.Drawing.Color.White;
			this.SubmitOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("SubmitOrderButton.Image")));
			this.SubmitOrderButton.ImagePosition = 20;
			this.SubmitOrderButton.ImageZoom = 40;
			this.SubmitOrderButton.LabelPosition = 41;
			this.SubmitOrderButton.LabelText = "SUBMIT ORDER";
			this.SubmitOrderButton.Location = new System.Drawing.Point(494, 6);
			this.SubmitOrderButton.Margin = new System.Windows.Forms.Padding(6);
			this.SubmitOrderButton.Name = "SubmitOrderButton";
			this.SubmitOrderButton.Size = new System.Drawing.Size(128, 129);
			this.SubmitOrderButton.TabIndex = 4;
			// 
			// CheckoutFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(800, 532);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.OrderItemsTableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CheckoutFormView";
			this.Text = "CheckoutFormView";
			this.OrderItemsTableLayoutPanel.ResumeLayout(false);
			this.OrderItemsTableLayoutPanel.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel OrderItemsTableLayoutPanel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuTileButton AddOrderItemButton;
		private System.Windows.Forms.Label OrderItemTotalLabel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label TotalPriceLabel;
		private Bunifu.Framework.UI.BunifuTileButton SubmitOrderButton;
	}
}