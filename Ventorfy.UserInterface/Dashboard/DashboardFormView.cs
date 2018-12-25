using System.Windows.Forms;

namespace Ventorfy.UserInterface.Dashboard
{
	public partial class DashboardFormView : Form, IDashboardFormView
	{

		private IDashboardFormPresenter _Presenter;

		public DashboardFormView()
		{
			InitializeComponent();
			this.CreatePresenter();
		}

		public void CreatePresenter()
		{
			this._Presenter = new DashboardFormPresenter();
			this._Presenter.SetView(this);
		}

	}
}
