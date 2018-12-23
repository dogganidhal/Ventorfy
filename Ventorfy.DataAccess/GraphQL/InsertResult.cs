using System.Collections.Generic;

namespace Ventorfy.DataAccess.GraphQL
{
	public class InsertResult<TModel>
	{
		
		public ICollection<TModel> returning;
		
		public ICollection<TModel> Result
		{
			get => returning;
		}

	}
}