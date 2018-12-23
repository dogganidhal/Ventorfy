using System;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations.Product
{
	public class InsertProductLotRequest : GraphQLRequest
	{

		public InsertProductLotRequest(Guid productId, Guid storeId) : base()
		{
			this.Query = @"
				mutation InsertProductLot($productId: ID!, $storeId: ID!){
					insert_ProductLot(objects:[
						{
							ProductId: $productId,
							Quantity: 0,
							StoreId: $storeId
						}
					])
					{
						returning {
							Id
							Quantity
							Store {
								Id
								Name
							}
							Product {
								Id
								Name
								Reference
								Price
								Provider {
									Id
									Name
								}
								Category {
									Id
									Name
								}
							}
						}
					}
				}";
			this.Variables = new
			{
				ProductId = productId,
				StoreId = storeId
			};
		}
		
	}
}