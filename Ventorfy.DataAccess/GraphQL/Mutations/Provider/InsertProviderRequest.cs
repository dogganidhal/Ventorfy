using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations.Provider
{
	public class InsertProviderRequest : GraphQLRequest
	{

		public InsertProviderRequest(string name) : base()
		{
			this.Query = @"
				mutation InsertProvider($name: String!) {
					insert_Provider(
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