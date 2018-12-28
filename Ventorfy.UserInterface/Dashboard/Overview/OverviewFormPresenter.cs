

using System;
using System.Collections.Generic;
using System.Linq;
using Ventorfy.DataAccess.Model.Orders;
using Ventorfy.DataAccess.Repository.Inventory;
using Ventorfy.DataAccess.Repository.Orders;
using Ventorfy.DataAccess.Repository.Products;
using Ventorfy.DataAccess.Repository.Users;
using Ventorfy.UserInterface.Session;

namespace Ventorfy.UserInterface.Dashboard.Overview
{
	class OverviewFormPresenter : IOverviewFormPresenter
	{

		private IOverviewFormView _View;
		private IUserRepository _UserRepository;
		private IClientOrderRepository _OrderRepository;
		private IStoreRepository _StoreRepository;
		private IProductRepository _ProductRepository;

		public OverviewFormPresenter(IUserRepository userRepository, IClientOrderRepository orderRepository, IStoreRepository storeRepository, IProductRepository productRepository)
		{
			this._UserRepository = userRepository;
			this._OrderRepository = orderRepository;
			this._StoreRepository = storeRepository;
			this._ProductRepository = productRepository;
		}

		public void SetView(IOverviewFormView view)
		{
			this._View = view;
		}

		public async void LoadData()
		{

			var store = UserSession.Instance.GetCurrentUser().Store;
			var staffMembers = await this._UserRepository.GetStoreStaffMembers(store);
			var recentOrders = (await this._OrderRepository.SelectOrders(store.Id, (order) =>
			{
				return DateTime.UtcNow.Subtract(order.Date).TotalDays < 7;
			})).OrderBy(order => order.Date).Take(3).ToList();
			var recentProducts = (await this._ProductRepository.GetProductsByStoreId(store.Id)).OrderBy(product => product.Created).Take(3).ToList();

			this._View.PopulateRecentOrders(recentOrders);
			this._View.PopulateRecentProducts(recentProducts);
			this._View.PopulateStaffMembers(staffMembers);

		}

		public void OnAddStaffMemberButtonClicked()
		{
			this._View.LaunchAddStaffMemberDialog();
		}

		public async void SubmitStaffMember(string username, string fullname, string password)
		{
			var staffMember = await this._StoreRepository.AddStaffMember(UserSession.Instance.GetCurrentUser().Store, username, fullname, password);
			this._View.AppendStaffMember(staffMember);
		}
	}
}
