using System;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Repository.Products;
using Ventorfy.UserInterface.Session;

namespace Ventorfy.UserInterface.Dashboard.Inventory
{
	class ProductInventoryFormPresenter : IProductInventoryFormPresenter
	{

		private IProductInventoryFormView _View;
		private IProductRepository _ProductRepository;

		public ProductInventoryFormPresenter(IProductRepository productRepository)
		{
			this._ProductRepository = productRepository;
		}

		public async void LoadData()
		{
			var products = await this._ProductRepository.GetProductsByStoreId(UserSession.Instance.GetCurrentUser().Store.Id);
			this._View.PopulateProducts(products);
		}

		public void OnAddProductButtonClicked()
		{
			this._View.LaunchAddProductDialog();
		}

		public async void OnAddProductSubmit(string reference, double price, string categoryName, string name = null)
		{
			var productCategory = await this._ProductRepository.CreateProductCategory(categoryName);
			var product = await this._ProductRepository.CreateProduct(
				store: UserSession.Instance.GetCurrentUser().Store, 
				price: price, 
				reference: reference, 
				category: productCategory, 
				name: name
			);

		}

		public void SetView(IProductInventoryFormView view)
		{
			this._View = view;
		}

	}
}
