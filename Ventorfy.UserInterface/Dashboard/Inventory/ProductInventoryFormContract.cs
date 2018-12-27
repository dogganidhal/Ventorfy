using System.Collections.Generic;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.Inventory
{
	public interface IProductInventoryFormView : IView
	{

		void PopulateProducts(ICollection<Product> products);
		void LaunchAddProductDialog();
		void AppendToProductList(Product product);

	}
	
	public interface IProductInventoryFormPresenter : IPresenter<IProductInventoryFormView>
	{

		void LoadData();
		void OnAddProductButtonClicked();
		void OnAddProductSubmit(string reference, double price, string categoryName, int quantity, string name = null);

	}
}
