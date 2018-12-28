using System;
using System.Windows.Forms;

namespace Ventorfy.UserInterface.Dashboard.AddMember
{
	public partial class AddMemberFormView : Form
	{
		public AddMemberFormView()
		{
			InitializeComponent();
			this.OkButton.Click += (object @object, EventArgs args) =>
			{
				this.DialogResult = DialogResult.OK;
			};
		}

		public string GetUserName()
		{
			return this.UserNameTextBox.Text;
		}

		public string GetFullName()
		{
			return this.FullNameTextBox.Text;
		}

		public string GetPassword()
		{
			return this.PasswordTextBox.Text;
		}
	}
}
