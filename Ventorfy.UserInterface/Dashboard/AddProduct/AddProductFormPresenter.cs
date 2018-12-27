using System.Collections.Generic;
using System.Linq;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Repository.Products;

namespace Ventorfy.UserInterface.Dashboard.AddProduct
{
	public class AddProductFormPresenter : IAddProductFormPresenter
	{

		private IAddProductFormView _View;

		public void SetView(IAddProductFormView view)
		{
			this._View = view;
		}

	}
}
