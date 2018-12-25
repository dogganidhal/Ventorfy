namespace Ventorfy.UserInterface.View
{
	partial class AuthForm
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
			this.LoginLabel = new System.Windows.Forms.Label();
			this.LoginUserNameTextBox = new System.Windows.Forms.TextBox();
			this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.SignUpLabel = new System.Windows.Forms.Label();
			this.SignUpPasswordTextBox = new System.Windows.Forms.TextBox();
			this.SignUpUserNameTextBox = new System.Windows.Forms.TextBox();
			this.SignUpFullNameTextBox = new System.Windows.Forms.TextBox();
			this.SignUpButton = new System.Windows.Forms.Button();
			this.LogoLabel = new System.Windows.Forms.Label();
			this.SignUpProgressBar = new System.Windows.Forms.ProgressBar();
			this.LoginProgressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginLabel.Location = new System.Drawing.Point(130, 148);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(62, 24);
			this.LoginLabel.TabIndex = 0;
			this.LoginLabel.Text = "Login";
			// 
			// LoginUserNameTextBox
			// 
			this.LoginUserNameTextBox.Location = new System.Drawing.Point(82, 202);
			this.LoginUserNameTextBox.Name = "LoginUserNameTextBox";
			this.LoginUserNameTextBox.Size = new System.Drawing.Size(166, 20);
			this.LoginUserNameTextBox.TabIndex = 1;
			this.LoginUserNameTextBox.Text = "Username";
			// 
			// LoginPasswordTextBox
			// 
			this.LoginPasswordTextBox.Location = new System.Drawing.Point(82, 243);
			this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
			this.LoginPasswordTextBox.PasswordChar = '*';
			this.LoginPasswordTextBox.Size = new System.Drawing.Size(166, 20);
			this.LoginPasswordTextBox.TabIndex = 2;
			this.LoginPasswordTextBox.Text = "Password";
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(82, 286);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(166, 23);
			this.LoginButton.TabIndex = 3;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			// 
			// SignUpLabel
			// 
			this.SignUpLabel.AutoSize = true;
			this.SignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SignUpLabel.Location = new System.Drawing.Point(476, 148);
			this.SignUpLabel.Name = "SignUpLabel";
			this.SignUpLabel.Size = new System.Drawing.Size(82, 24);
			this.SignUpLabel.TabIndex = 4;
			this.SignUpLabel.Text = "Sign up";
			// 
			// SignUpPasswordTextBox
			// 
			this.SignUpPasswordTextBox.Location = new System.Drawing.Point(429, 289);
			this.SignUpPasswordTextBox.Name = "SignUpPasswordTextBox";
			this.SignUpPasswordTextBox.PasswordChar = '*';
			this.SignUpPasswordTextBox.Size = new System.Drawing.Size(166, 20);
			this.SignUpPasswordTextBox.TabIndex = 6;
			this.SignUpPasswordTextBox.Text = "Password";
			// 
			// SignUpUserNameTextBox
			// 
			this.SignUpUserNameTextBox.Location = new System.Drawing.Point(429, 202);
			this.SignUpUserNameTextBox.Name = "SignUpUserNameTextBox";
			this.SignUpUserNameTextBox.Size = new System.Drawing.Size(166, 20);
			this.SignUpUserNameTextBox.TabIndex = 5;
			this.SignUpUserNameTextBox.Text = "Username";
			// 
			// SignUpFullNameTextBox
			// 
			this.SignUpFullNameTextBox.Location = new System.Drawing.Point(429, 243);
			this.SignUpFullNameTextBox.Name = "SignUpFullNameTextBox";
			this.SignUpFullNameTextBox.Size = new System.Drawing.Size(166, 20);
			this.SignUpFullNameTextBox.TabIndex = 7;
			this.SignUpFullNameTextBox.Text = "Full name";
			// 
			// SignUpButton
			// 
			this.SignUpButton.Location = new System.Drawing.Point(429, 335);
			this.SignUpButton.Name = "SignUpButton";
			this.SignUpButton.Size = new System.Drawing.Size(166, 23);
			this.SignUpButton.TabIndex = 8;
			this.SignUpButton.Text = "Sign up";
			this.SignUpButton.UseVisualStyleBackColor = true;
			// 
			// LogoLabel
			// 
			this.LogoLabel.AutoSize = true;
			this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogoLabel.Location = new System.Drawing.Point(295, 46);
			this.LogoLabel.Name = "LogoLabel";
			this.LogoLabel.Size = new System.Drawing.Size(117, 29);
			this.LogoLabel.TabIndex = 9;
			this.LogoLabel.Text = "VentorFy";
			// 
			// SignUpProgressBar
			// 
			this.SignUpProgressBar.Location = new System.Drawing.Point(429, 381);
			this.SignUpProgressBar.Name = "SignUpProgressBar";
			this.SignUpProgressBar.Size = new System.Drawing.Size(166, 23);
			this.SignUpProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.SignUpProgressBar.TabIndex = 10;
			this.SignUpProgressBar.Visible = false;
			// 
			// LoginProgressBar
			// 
			this.LoginProgressBar.Location = new System.Drawing.Point(82, 335);
			this.LoginProgressBar.Name = "LoginProgressBar";
			this.LoginProgressBar.Size = new System.Drawing.Size(166, 23);
			this.LoginProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.LoginProgressBar.TabIndex = 11;
			this.LoginProgressBar.Visible = false;
			// 
			// AuthForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 450);
			this.Controls.Add(this.LoginProgressBar);
			this.Controls.Add(this.SignUpProgressBar);
			this.Controls.Add(this.LogoLabel);
			this.Controls.Add(this.SignUpButton);
			this.Controls.Add(this.SignUpFullNameTextBox);
			this.Controls.Add(this.SignUpPasswordTextBox);
			this.Controls.Add(this.SignUpUserNameTextBox);
			this.Controls.Add(this.SignUpLabel);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.LoginPasswordTextBox);
			this.Controls.Add(this.LoginUserNameTextBox);
			this.Controls.Add(this.LoginLabel);
			this.Name = "AuthForm";
			this.Text = "Authentication";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LoginLabel;
		private System.Windows.Forms.TextBox LoginUserNameTextBox;
		private System.Windows.Forms.TextBox LoginPasswordTextBox;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Label SignUpLabel;
		private System.Windows.Forms.TextBox SignUpPasswordTextBox;
		private System.Windows.Forms.TextBox SignUpUserNameTextBox;
		private System.Windows.Forms.TextBox SignUpFullNameTextBox;
		private System.Windows.Forms.Button SignUpButton;
		private System.Windows.Forms.Label LogoLabel;
		private System.Windows.Forms.ProgressBar SignUpProgressBar;
		private System.Windows.Forms.ProgressBar LoginProgressBar;
	}
}