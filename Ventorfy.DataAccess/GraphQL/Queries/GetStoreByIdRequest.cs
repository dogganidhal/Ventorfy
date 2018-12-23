using System;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Queries
{
	public class GetStoreByIdRequest : GraphQLRequest
	{

		public GetStoreByIdRequest(Guid id) : base()
		{
			this.Query = @"
				query GetStoreById($id: ID) {
					Store(where:{
						Id: {
							_eq: $id
						}
					})
					{
						Id
						Name
						Admin {
							Id
							UserName
							FullName
						}
						StaffMembers {
							Id
							UserName
							FullName
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