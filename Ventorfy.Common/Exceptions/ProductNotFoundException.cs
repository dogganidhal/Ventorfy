using System;

namespace Ventorfy.Common.Exceptions
{
	public class ProductNotFoundException : Exception
	{

		public ProductNotFoundException(Guid id) : base($"No product with id {id} was found")
		{
			
		}
		
	}
}