using System;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations.Product
{
	public class UpdateProductSetProviderRequest : GraphQLRequest
	{

		public UpdateProductSetProviderRequest(Guid id, Guid providerId): base()
		{
		  this.Query = @"
        mutation UpdateProduct_SetProvider($id: ID!, $providerId: ID!) {
          update_Product(_set: {
            ProviderId: $providerId
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
            }
          }
        }";
			this.Variables = new
			{
				Id = id,
				ProviderId = providerId
			};
		}
		
	}
}