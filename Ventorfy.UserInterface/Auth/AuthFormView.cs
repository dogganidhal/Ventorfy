using System;
using System.Windows.Forms;
using Ventorfy.DataAccess.Repository;
using Ventorfy.UserInterface.Dashboard;

namespace Ventorfy.UserInterface.Auth
{
	public partial class AuthFormView : Form, IAuthFormView
	{

		private IAuthFormPresenter _Presenter;

		public AuthFormView()
		{
			this.InitializeComponent();
			this.CreatePresenter();
			this._SetupView();
		}

		public void CreatePresenter()
		{
			this._Presenter = new AuthFormPresenter(RepositoryFactory.Instance.UserRepository);
			this._Presenter.SetView(this);
		}

		public void DisplayError(string message)
		{
			MessageBox.Show(message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void DisplayLoginProgressBar()
		{
			this.LoginProgressBar.Show();
			this.LoginProgressBar.Style = ProgressBarStyle.Marquee;
		}

		public void DisplaySignUpProgressBar()
		{
			this.SignUpProgressBar.Show();
			this.SignUpProgressBar.Style = ProgressBarStyle.Marquee;
		}

		public void HideLoginProgressBar()
		{
			this.LoginProgressBar.Hide();
			this.LoginProgressBar.Style = ProgressBarStyle.Continuous;
		}

		public void HideSignUpProgressBar()
		{
			this.SignUpProgressBar.Hide();
			this.SignUpProgressBar.Style = ProgressBarStyle.Continuous;
		}

		public void LaunchDashboardForm()
		{
			var mainMenuForm = new DashboardFormView();
			mainMenuForm.Show();
			this.Visible = false;
		}

		private void _SetupView()
		{

			this.LoginButton.Click += (object @object, EventArgs args) =>
			{
				var userName = this.LoginUserNameTextBox.Text;
				var password = this.LoginPasswordTextBox.Text;
				this._Presenter.OnLoginButtonPressed(userName, password);
			};
			this.SignUpButton.Click += (object @object, EventArgs args) =>
			{
				var userName = this.SignUpUserNameTextBox.Text;
				var fullName = this.SignUpFullNameTextBox.Text;
				var password = this.SignUpPasswordTextBox.Text;
				this._Presenter.OnSignUpButtonPressed(userName, fullName, password);

			};
			this.LoginProgressBar.MarqueeAnimationSpeed = 100;
			this.SignUpProgressBar.MarqueeAnimationSpeed = 100;

		}



	}
}
