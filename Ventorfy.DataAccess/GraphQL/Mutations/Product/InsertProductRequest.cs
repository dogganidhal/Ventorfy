using System;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations.Product
{
	public class InsertProductRequest : GraphQLRequest
	{

		public InsertProductRequest(string reference, Guid categoryId, double price, Guid? providerId = null,
			string name = null) : base()
		{
			this.Query = @"
				mutation InsertProduct($reference: String!, $price: Float!, $categoryId: ID!, $name: String = null, $providerId: ID = null) {
					insert_Product(
						objects: [
							{Reference: $reference, Name: $name, Price: $price, ProviderId: $providerId, CategoryId: $categoryId}
						]
					)
					{
						returning {
							Id
							Name
							Reference
							Category{
								Id
								Name
							}
							Provider {
								Id
								Name
							}
							Price
						}
					}
				}";
			this.Variables = new
			{
				Name = name,
				Reference = reference,
				Price = price,
				CategoryId = categoryId,
				ProviderId = providerId
			};
		}
		
	}
}