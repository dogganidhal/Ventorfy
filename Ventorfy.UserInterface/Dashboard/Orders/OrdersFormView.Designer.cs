﻿namespace Ventorfy.UserInterface.Dashboard.Orders
{
	partial class OrdersFormView
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
			this.OrdersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.OrdersTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// OrdersTableLayoutPanel
			// 
			this.OrdersTableLayoutPanel.AutoScroll = true;
			this.OrdersTableLayoutPanel.ColumnCount = 4;
			this.OrdersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.OrdersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.OrdersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.OrdersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.OrdersTableLayoutPanel.Controls.Add(this.label4, 0, 0);
			this.OrdersTableLayoutPanel.Controls.Add(this.label3, 0, 0);
			this.OrdersTableLayoutPanel.Controls.Add(this.label1, 0, 0);
			this.OrdersTableLayoutPanel.Controls.Add(this.label2, 0, 0);
			this.OrdersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OrdersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.OrdersTableLayoutPanel.Name = "OrdersTableLayoutPanel";
			this.OrdersTableLayoutPanel.RowCount = 1;
			this.OrdersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OrdersTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
			this.OrdersTableLayoutPanel.TabIndex = 1;
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
			this.label4.Text = "Total items";
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
			this.label3.Text = "Total price";
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
			this.label1.Text = "Date";
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
			this.label2.Text = "Author";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OrdersFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.OrdersTableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OrdersFormView";
			this.Text = "OrdersFormView";
			this.OrdersTableLayoutPanel.ResumeLayout(false);
			this.OrdersTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel OrdersTableLayoutPanel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}