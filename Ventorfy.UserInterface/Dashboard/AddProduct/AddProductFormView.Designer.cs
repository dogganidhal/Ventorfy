namespace Ventorfy.UserInterface.Dashboard.AddProduct
{
	partial class AddProductFormView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductFormView));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
			this.OkButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.ProductReferenceTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.ProductNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.UnitPriceTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.CategoryNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.QuantityTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.SuspendLayout();
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
			this.OkButton.Location = new System.Drawing.Point(269, 334);
			this.OkButton.Name = "OkButton";
			stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties1.BorderRadius = 1;
			stateProperties1.BorderThickness = 1;
			stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties1.IconLeftImage = null;
			stateProperties1.IconRightImage = null;
			this.OkButton.onHoverState = stateProperties1;
			this.OkButton.Size = new System.Drawing.Size(210, 45);
			this.OkButton.TabIndex = 25;
			this.OkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ProductReferenceTextBox
			// 
			this.ProductReferenceTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.ProductReferenceTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.ProductReferenceTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.ProductReferenceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProductReferenceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProductReferenceTextBox.ForeColor = System.Drawing.Color.Silver;
			this.ProductReferenceTextBox.HintForeColor = System.Drawing.Color.Silver;
			this.ProductReferenceTextBox.HintText = "Product Reference";
			this.ProductReferenceTextBox.isPassword = false;
			this.ProductReferenceTextBox.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProductReferenceTextBox.LineIdleColor = System.Drawing.Color.WhiteSmoke;
			this.ProductReferenceTextBox.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProductReferenceTextBox.LineThickness = 4;
			this.ProductReferenceTextBox.Location = new System.Drawing.Point(9, 59);
			this.ProductReferenceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProductReferenceTextBox.MaxLength = 32767;
			this.ProductReferenceTextBox.Name = "ProductReferenceTextBox";
			this.ProductReferenceTextBox.Size = new System.Drawing.Size(353, 43);
			this.ProductReferenceTextBox.TabIndex = 26;
			this.ProductReferenceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// ProductNameTextBox
			// 
			this.ProductNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.ProductNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.ProductNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.ProductNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProductNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProductNameTextBox.ForeColor = System.Drawing.Color.Silver;
			this.ProductNameTextBox.HintForeColor = System.Drawing.Color.Silver;
			this.ProductNameTextBox.HintText = "Product Name (Optional)";
			this.ProductNameTextBox.isPassword = false;
			this.ProductNameTextBox.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProductNameTextBox.LineIdleColor = System.Drawing.Color.WhiteSmoke;
			this.ProductNameTextBox.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProductNameTextBox.LineThickness = 4;
			this.ProductNameTextBox.Location = new System.Drawing.Point(9, 149);
			this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProductNameTextBox.MaxLength = 32767;
			this.ProductNameTextBox.Name = "ProductNameTextBox";
			this.ProductNameTextBox.Size = new System.Drawing.Size(353, 43);
			this.ProductNameTextBox.TabIndex = 27;
			this.ProductNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// UnitPriceTextBox
			// 
			this.UnitPriceTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.UnitPriceTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.UnitPriceTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.UnitPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.UnitPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UnitPriceTextBox.ForeColor = System.Drawing.Color.Silver;
			this.UnitPriceTextBox.HintForeColor = System.Drawing.Color.Silver;
			this.UnitPriceTextBox.HintText = "Unit Price ";
			this.UnitPriceTextBox.isPassword = false;
			this.UnitPriceTextBox.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.UnitPriceTextBox.LineIdleColor = System.Drawing.Color.WhiteSmoke;
			this.UnitPriceTextBox.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.UnitPriceTextBox.LineThickness = 4;
			this.UnitPriceTextBox.Location = new System.Drawing.Point(385, 149);
			this.UnitPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.UnitPriceTextBox.MaxLength = 32767;
			this.UnitPriceTextBox.Name = "UnitPriceTextBox";
			this.UnitPriceTextBox.Size = new System.Drawing.Size(353, 43);
			this.UnitPriceTextBox.TabIndex = 29;
			this.UnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// CategoryNameTextBox
			// 
			this.CategoryNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.CategoryNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.CategoryNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.CategoryNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CategoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CategoryNameTextBox.ForeColor = System.Drawing.Color.Silver;
			this.CategoryNameTextBox.HintForeColor = System.Drawing.Color.Silver;
			this.CategoryNameTextBox.HintText = "Category Name ";
			this.CategoryNameTextBox.isPassword = false;
			this.CategoryNameTextBox.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.CategoryNameTextBox.LineIdleColor = System.Drawing.Color.WhiteSmoke;
			this.CategoryNameTextBox.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.CategoryNameTextBox.LineThickness = 4;
			this.CategoryNameTextBox.Location = new System.Drawing.Point(385, 59);
			this.CategoryNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CategoryNameTextBox.MaxLength = 32767;
			this.CategoryNameTextBox.Name = "CategoryNameTextBox";
			this.CategoryNameTextBox.Size = new System.Drawing.Size(353, 43);
			this.CategoryNameTextBox.TabIndex = 28;
			this.CategoryNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// QuantityTextBox
			// 
			this.QuantityTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.QuantityTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.QuantityTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.QuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.QuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QuantityTextBox.ForeColor = System.Drawing.Color.Silver;
			this.QuantityTextBox.HintForeColor = System.Drawing.Color.Silver;
			this.QuantityTextBox.HintText = "Quantity ";
			this.QuantityTextBox.isPassword = false;
			this.QuantityTextBox.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.QuantityTextBox.LineIdleColor = System.Drawing.Color.WhiteSmoke;
			this.QuantityTextBox.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.QuantityTextBox.LineThickness = 4;
			this.QuantityTextBox.Location = new System.Drawing.Point(198, 246);
			this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.QuantityTextBox.MaxLength = 32767;
			this.QuantityTextBox.Name = "QuantityTextBox";
			this.QuantityTextBox.Size = new System.Drawing.Size(353, 43);
			this.QuantityTextBox.TabIndex = 30;
			this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// AddProductFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(753, 431);
			this.Controls.Add(this.QuantityTextBox);
			this.Controls.Add(this.UnitPriceTextBox);
			this.Controls.Add(this.CategoryNameTextBox);
			this.Controls.Add(this.ProductNameTextBox);
			this.Controls.Add(this.ProductReferenceTextBox);
			this.Controls.Add(this.OkButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddProductFormView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddProductFormView";
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.UI.WinForms.BunifuButton.BunifuButton OkButton;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProductReferenceTextBox;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProductNameTextBox;
		private Bunifu.Framework.UI.BunifuMaterialTextbox UnitPriceTextBox;
		private Bunifu.Framework.UI.BunifuMaterialTextbox CategoryNameTextBox;
		private Bunifu.Framework.UI.BunifuMaterialTextbox QuantityTextBox;
	}
}