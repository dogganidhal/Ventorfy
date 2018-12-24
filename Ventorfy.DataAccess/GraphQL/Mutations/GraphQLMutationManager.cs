using System.IO;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations
{
	public class GraphQLMutationManager
	{
		
		private static readonly GraphQLMutationManager _Instance = new GraphQLMutationManager();

		public sealed class MutationRequest
		{

			public static string InsertUser = "User.InsertUser.graphql";
			public static string InsertStore = "Store.InsertStore.graphql";
			public static string InsertProvider = "Provider.InsertProvider.graphql";
			public static string UpdateProduct_SetProductLot = "Product.UpdateProduct_SetProductLot.graphql";
			public static string UpdateProduct_SetProvider = "Product.UpdateProduct_SetProvider.graphql";
			public static string InsertProduct = "Product.InsertProduct.graphql";
			public static string InsertProductLot = "Product.InsertProductLot.graphql";
			public static string InsertProductCategory = "Product.InsertProductCategory.graphql";
			public static string AlterProductLotQuantity = "Product.AlterProductLotQuantity.graphql";
			public static string InsertClientOrderItem = "Order.InsertClientOrderItem.graphql";
			public static string UpdateClientOrderItem_SetClientOrder = "Order.UpdateClientOrderItem_SetClientOrder.graphql";
			public static string InsertOrderClient = "Order.InsertClientOrder.graphql";
			public static string UpdateUser_SetStore = "User.UpdateUser_SetStore.graphql";

		}

		public static GraphQLRequest GetMutationRequest(string queryRequest, dynamic variables)
		{
			var @namespace = _Instance.GetType().Namespace;
			var stream = _Instance.GetType().Assembly.GetManifestResourceStream($"{@namespace}.{queryRequest}");
			var reader = new StreamReader(stream);
			var query = reader.ReadToEnd();
			
			return new GraphQLRequest() { Query = query, Variables = variables};
		}
		
	}
}