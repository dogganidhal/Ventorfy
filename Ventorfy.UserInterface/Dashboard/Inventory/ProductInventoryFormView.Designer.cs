namespace Ventorfy.UserInterface.Dashboard.Inventory
{
	partial class ProductInventoryFormView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInventoryFormView));
			this.ProductsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AddProductButton = new Bunifu.Framework.UI.BunifuTileButton();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.ProductsTableLayoutPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ProductsTableLayoutPanel
			// 
			this.ProductsTableLayoutPanel.ColumnCount = 4;
			this.ProductsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.ProductsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.ProductsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.ProductsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.ProductsTableLayoutPanel.Controls.Add(this.label4, 0, 0);
			this.ProductsTableLayoutPanel.Controls.Add(this.label3, 0, 0);
			this.ProductsTableLayoutPanel.Controls.Add(this.label1, 0, 0);
			this.ProductsTableLayoutPanel.Controls.Add(this.label2, 0, 0);
			this.ProductsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ProductsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.ProductsTableLayoutPanel.Name = "ProductsTableLayoutPanel";
			this.ProductsTableLayoutPanel.RowCount = 1;
			this.ProductsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ProductsTableLayoutPanel.Size = new System.Drawing.Size(800, 64);
			this.ProductsTableLayoutPanel.TabIndex = 4;
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
			this.label4.Text = "Quantity";
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
			this.label2.Text = "Reference";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AddProductButton
			// 
			this.AddProductButton.BackColor = System.Drawing.Color.Transparent;
			this.AddProductButton.color = System.Drawing.Color.Transparent;
			this.AddProductButton.colorActive = System.Drawing.Color.Transparent;
			this.AddProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.AddProductButton.ForeColor = System.Drawing.Color.White;
			this.AddProductButton.Image = ((System.Drawing.Image)(resources.GetObject("AddProductButton.Image")));
			this.AddProductButton.ImagePosition = 20;
			this.AddProductButton.ImageZoom = 40;
			this.AddProductButton.LabelPosition = 41;
			this.AddProductButton.LabelText = "ADD PRODUCT";
			this.AddProductButton.Location = new System.Drawing.Point(6, 6);
			this.AddProductButton.Margin = new System.Windows.Forms.Padding(6);
			this.AddProductButton.Name = "AddProductButton";
			this.AddProductButton.Size = new System.Drawing.Size(128, 129);
			this.AddProductButton.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.AddProductButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 315);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 135);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// ProductInventoryFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ProductsTableLayoutPanel);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ProductInventoryFormView";
			this.Text = "ProductInventoryFormView";
			this.ProductsTableLayoutPanel.ResumeLayout(false);
			this.ProductsTableLayoutPanel.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel ProductsTableLayoutPanel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuTileButton AddProductButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}