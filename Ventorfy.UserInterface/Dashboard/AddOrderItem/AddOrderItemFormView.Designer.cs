namespace Ventorfy.UserInterface.Dashboard.AddOrderItem
{
	partial class AddOrderItemFormView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderItemFormView));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
			this.ProductsListBox = new System.Windows.Forms.ListBox();
			this.ProductGroupBox = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ItemCountTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.OkButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.ProductGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ProductsListBox
			// 
			this.ProductsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.ProductsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ProductsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProductsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProductsListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ProductsListBox.FormattingEnabled = true;
			this.ProductsListBox.ItemHeight = 21;
			this.ProductsListBox.Items.AddRange(new object[] {
            "QOIEQBOIUQ00BR1083140EIEQP (Another Test Product)",
            "AEOFQ91308QEIFb (Test Product)"});
			this.ProductsListBox.Location = new System.Drawing.Point(3, 29);
			this.ProductsListBox.Name = "ProductsListBox";
			this.ProductsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.ProductsListBox.Size = new System.Drawing.Size(433, 185);
			this.ProductsListBox.TabIndex = 0;
			// 
			// ProductGroupBox
			// 
			this.ProductGroupBox.Controls.Add(this.ProductsListBox);
			this.ProductGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProductGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ProductGroupBox.Location = new System.Drawing.Point(30, 27);
			this.ProductGroupBox.Name = "ProductGroupBox";
			this.ProductGroupBox.Size = new System.Drawing.Size(439, 217);
			this.ProductGroupBox.TabIndex = 1;
			this.ProductGroupBox.TabStop = false;
			this.ProductGroupBox.Text = "Select Product";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ItemCountTextBox);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Location = new System.Drawing.Point(30, 260);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(439, 119);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Set Count";
			// 
			// ItemCountTextBox
			// 
			this.ItemCountTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.ItemCountTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.ItemCountTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.ItemCountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ItemCountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemCountTextBox.ForeColor = System.Drawing.Color.Silver;
			this.ItemCountTextBox.HintForeColor = System.Drawing.Color.Gainsboro;
			this.ItemCountTextBox.HintText = "Count";
			this.ItemCountTextBox.isPassword = false;
			this.ItemCountTextBox.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ItemCountTextBox.LineIdleColor = System.Drawing.Color.WhiteSmoke;
			this.ItemCountTextBox.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ItemCountTextBox.LineThickness = 4;
			this.ItemCountTextBox.Location = new System.Drawing.Point(42, 49);
			this.ItemCountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ItemCountTextBox.MaxLength = 32767;
			this.ItemCountTextBox.Name = "ItemCountTextBox";
			this.ItemCountTextBox.Size = new System.Drawing.Size(353, 43);
			this.ItemCountTextBox.TabIndex = 2;
			this.ItemCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.Transparent;
			this.OkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkButton.BackgroundImage")));
			this.OkButton.ButtonText = "OK";
			this.OkButton.ButtonTextMarginLeft = 0;
			this.OkButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.OkButton.DisabledFillColor = System.Drawing.Color.Gray;
			this.OkButton.DisabledForecolor = System.Drawing.Color.White;
			this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
			this.OkButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.OkButton.IconPadding = 10;
			this.OkButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.OkButton.IdleBorderColor = System.Drawing.Color.WhiteSmoke;
			this.OkButton.IdleBorderRadius = 1;
			this.OkButton.IdleBorderThickness = 0;
			this.OkButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
			this.OkButton.IdleIconLeftImage = null;
			this.OkButton.IdleIconRightImage = null;
			this.OkButton.Location = new System.Drawing.Point(137, 407);
			this.OkButton.Name = "OkButton";
			stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties5.BorderRadius = 1;
			stateProperties5.BorderThickness = 1;
			stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties5.IconLeftImage = null;
			stateProperties5.IconRightImage = null;
			this.OkButton.onHoverState = stateProperties5;
			this.OkButton.Size = new System.Drawing.Size(210, 45);
			this.OkButton.TabIndex = 23;
			this.OkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AddOrderItemFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(504, 477);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ProductGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddOrderItemFormView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddOrderItemFormView";
			this.ProductGroupBox.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox ProductsListBox;
		private System.Windows.Forms.GroupBox ProductGroupBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ItemCountTextBox;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton OkButton;
	}
}