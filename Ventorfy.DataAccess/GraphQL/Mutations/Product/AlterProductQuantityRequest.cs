using System;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations.Product
{
	public class AlterProductQuantityRequest : GraphQLRequest
	{

		public AlterProductQuantityRequest(Guid productLotId, int newQuantity) : base()
		{
			this.Query = @"
        mutation AlterProductLotQuantity($productLotId: ID!, $newQuantity: Int!) {
          update_ProductLot(_set:{
            Quantity: $newQuantity
          }, where: {
            Id: {
              _eq: $productLotId
            }
          })
          {
            returning {
              Id
              Quantity
              Product {
                Id
                Name
                Reference
                Price
                Category {
                  Name
                  Id
                }
              }
              Store {
                Id
                Name
                Admin {
                  Id
                  FullName
                  UserName
                }
              }
            }
          }
        }";
		  this.Variables = new
		  {
        ProductLotId = productLotId,
		    NewQuantity = newQuantity
		  };
		}
		
	}
}