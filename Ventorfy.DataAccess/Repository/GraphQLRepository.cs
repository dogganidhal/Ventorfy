using GraphQL.Client;

namespace Ventorfy.DataAccess.Repository
{
	public abstract class GraphQLRepository
	{
		
		protected readonly GraphQLClient _Client;

		public GraphQLRepository(GraphQLClient client)
		{
			this._Client = client;
		}
		
	}
}