using System.Collections;
using System.Collections.Generic;
using Ventorfy.DataAccess.Model.Orders;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Model.Users;
using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.Overview
{
	public interface IOverviewFormView : IView
	{

		void PopulateProfitsProgress();
		void PopulateRecentOrders(ICollection<ClientOrder> orders);
		void PopulateRecentProducts(ICollection<Product> products);
		void PopulateStaffMembers(ICollection<User> members);
		void LaunchAddStaffMemberDialog();
		void AppendStaffMember(User member);

	}

	public interface IOverviewFormPresenter : IPresenter<IOverviewFormView>
	{

		void LoadData();
		void OnAddStaffMemberButtonClicked();
		void SubmitStaffMember(string username, string fullname, string password);
	}
}
