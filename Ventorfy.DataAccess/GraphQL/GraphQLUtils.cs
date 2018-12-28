using System;
using GraphQL.Client;

namespace Ventorfy.DataAccess.GraphQL
{

	public static class GraphQLUtils {

		public static GraphQLClient CreateGraphQlClient()
		{
			var client = new GraphQLClient(new Uri("https://ventorfy.herokuapp.com/v1alpha1/graphql"));
			client.DefaultRequestHeaders.Add("X-Hasura-Access-Key", "insta2018");
			return client;
		}
		
	}
	
}