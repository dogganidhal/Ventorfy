using System.IO;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Queries
{
	public class GraphQLQueryManager
	{
		
		private static readonly GraphQLQueryManager _Instance = new GraphQLQueryManager();

		public sealed class QueryRequest
		{

			public static string GetUserByUserName = "User.GetUserByUserName.graphql";
			public static string GetStoreById = "Store.GetStoreById.graphql";
			public static string GetProductById = "Product.GetProductById.graphql";
			public static string GetProductCategoryById = "Product.GetProductCategoryById.graphql";
			public static string GetProductLotByProductId = "Product.GetProductLotByProductId.graphql";
			public static string GetClientOrdersForStore = "Order.GetClientOrdersForStore.graphql";
			public static string GetProductsByStoreId = "Product.GetProductsByStoreId.graphql";
			public static string GetStoreStaffMembers = "User.GetStoreStaffMembers.graphql";

		}

		public static GraphQLRequest GetQueryRequest(string queryRequest, dynamic variables)
		{
			var @namespace = _Instance.GetType().Namespace;
			var stream = _Instance.GetType().Assembly.GetManifestResourceStream($"{@namespace}.{queryRequest}");
			var reader = new StreamReader(stream);
			var query = reader.ReadToEnd();

			return new GraphQLRequest {Query = query, Variables = variables};
		}
		
	}
}