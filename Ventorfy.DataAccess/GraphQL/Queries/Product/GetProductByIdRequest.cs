using System;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Queries.Product
{
	public class GetProductByIdRequest : GraphQLRequest
	{

		public GetProductByIdRequest(Guid id) : base()
		{
		  this.Query = @"
				query GetProductById($id:ID!) {
					Product(where:{
						Id: {
							_eq: $id
						}
					})
					{
						Id
						Name,
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
				}";
			this.Variables = new
			{
				Id = id
			};
		}
		
	}
}