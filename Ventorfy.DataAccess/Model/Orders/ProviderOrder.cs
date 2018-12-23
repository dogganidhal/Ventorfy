using System.ComponentModel.DataAnnotations;
using Ventorfy.DataAccess.Model.Inventory;

namespace Ventorfy.DataAccess.Model.Orders
{
	public class ProviderOrder : Order
	{

		public Provider Provider { get; set; }
		
	}
}