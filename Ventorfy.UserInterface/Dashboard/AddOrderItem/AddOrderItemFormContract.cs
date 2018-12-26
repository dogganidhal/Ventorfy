using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.UserInterface.MVP;

namespace Ventorfy.UserInterface.Dashboard.AddOrderItem
{
	public interface IAddOrderItemFormView : IView
	{

		Product GetSelectedProduct();


	}

	public interface IAddOrderItemFormPresenter : IPresenter<IAddOrderItemFormView>
	{

		

	}
}
