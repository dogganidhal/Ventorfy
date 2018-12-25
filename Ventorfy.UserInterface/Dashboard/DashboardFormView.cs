using System;
using System.Drawing;
using System.Windows.Forms;
using Ventorfy.UserInterface.Auth;

namespace Ventorfy.UserInterface.Dashboard
{
	public partial class DashboardFormView : Form, IDashboardFormView
	{

		private IDashboardFormPresenter _Presenter;

		public DashboardFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
			this._SetUpView();
		}

		public void CreatePresenter()
		{
			this._Presenter = new DashboardFormPresenter();
			this._Presenter.SetView(this);
		}

		public void DisplayLogOutConfirmationDialog()
		{
			var dialogResult = MessageBox.Show("Are you sure you want to log out?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult == DialogResult.Yes)
			{
				this._Presenter.OnLogOutConfirm();
			}
		}

		public void LaunchAuthFormView()
		{
			var authFormView = new AuthFormView();
			authFormView.Show();
			this.Visible = false;
		}

		private void _SetUpView()
		{
			
		}
	}
}
