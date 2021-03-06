﻿using System;
using System.Collections.Generic;
using System.Linq;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Repository.Products;
using Ventorfy.UserInterface.Session;

namespace Ventorfy.UserInterface.Dashboard.AddOrderItem
{
	public class AddOrderItemPresenter : IAddOrderItemFormPresenter
	{

		private IAddOrderItemFormView _View;
		private IProductRepository _ProductRepository;
		private ICollection<Product> _Products;

		public AddOrderItemPresenter(IProductRepository productRepository)
		{
			this._ProductRepository = productRepository;
		}

		public Product GetProductAtIndex(int index)
		{
			return this._Products.ElementAt(index);
		}

		public async void LoadData()
		{
			var storeId = UserSession.Instance.GetCurrentUser()?.Store?.Id;
			if (storeId != null) // Should always be
			{
				this._Products = await this._ProductRepository.GetProductsByStoreId((Guid)storeId);
				this._View.PopulateProducts(this._Products);
			}	
		}

		public void SetView(IAddOrderItemFormView view)
		{
			this._View = view;
		}

	}
}
