using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations.Product
{
	public class InsertProductCategoryRequest : GraphQLRequest
	{

		public InsertProductCategoryRequest(string name) : base()
		{
			this.Query = @"
				mutation InsertProduct($name: String!) {
					insert_ProductCategory(
						objects: [
							{Name: $name}
						]
					)
					{
						returning {
							Id
							Name
						}
					}
				}";
			this.Variables = new
			{
				Name = name
			};
		}
		
	}
}