using System;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.AddProduct
{
	public interface IAddProductFormView : IView
	{
		
		string GetProductReference();
		string GetProductName();
		double GetPrice();
		string GetProductCategoryName();
		int GetQuantity();

	}

	public interface IAddProductFormPresenter : IPresenter<IAddProductFormView>
	{

	}
}
