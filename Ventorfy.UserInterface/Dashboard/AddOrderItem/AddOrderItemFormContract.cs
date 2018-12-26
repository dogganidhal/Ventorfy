using System;
using System.Collections.Generic;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.AddOrderItem
{
	public interface IAddOrderItemFormView : IView
	{

		void PopulateProducts(ICollection<Product> products);
		Product GetSelectedProduct();
		int GetItemCount();

	}

	public interface IAddOrderItemFormPresenter : IPresenter<IAddOrderItemFormView>
	{

		void LoadData();
		Product GetProductAtIndex(int index);

	}
}
