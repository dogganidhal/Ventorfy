using System;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations.Product
{
	public class UpdateProductSetProductLotRequest : GraphQLRequest
	{

		public UpdateProductSetProductLotRequest(Guid productId, Guid productLotId) : base()
		{
		  this.Query = @"
        mutation UpdateProduct_SetProductLot($id: ID!, $productLotId: ID!) {
          update_Product(_set: {
            ProductLotId: $productLotId
          }, where:{
            Id: {
              _eq: $id
            }
          })
          {
            returning {
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
              ProductLot {
                Id
                Quantity
                Store {
                  Id
                  Name
                }
              }
            }
          }
        }";
		  this.Variables = new
		  {
        Id = productId,
		    ProductLotId = productLotId
		  };
		}
		
	}
}