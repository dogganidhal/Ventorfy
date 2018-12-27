using System.Collections.Generic;
using System.Linq;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Repository.Products;

namespace Ventorfy.UserInterface.Dashboard.AddProduct
{
	public class AddProductFormPresenter : IAddProductFormPresenter
	{

		private IAddProductFormView _View;
		private IProductRepository _ProductRepository;
		private ICollection<string> _ProductCategories = new List<string>();

		public AddProductFormPresenter(IProductRepository productRepository) 
		{
			this._ProductRepository = productRepository;
		}
		
		public string GetProductCategoryAtIndex(int index)
		{
			return this._ProductCategories.ElementAt(index);
		}

		public async void LoadData()
		{
		}

		public void SetView(IAddProductFormView view)
		{
			this._View = view;
		}

	}
}
