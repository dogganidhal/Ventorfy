using System;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations
{
	public class InsertStoreRequest : GraphQLRequest
	{

		public InsertStoreRequest(Guid adminId, string name) : base()
		{
		  this.Query = @"
				mutation InsertStore($adminId: ID, $name: ID) {
					insert_Store(
						objects: [
							{AdminId: $adminId, Name: $name}
						]
					)
					{
						returning {
							Id
							Name
							Admin {
								Id
								UserName
								FullName
							}
						}
					}
				}
			";
			this.Variables = new
			{
				AdminId = adminId,
				Name = name
			};
		}
		
	}
}