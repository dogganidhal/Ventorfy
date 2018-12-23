using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Queries.User
{
	public class GetUserByUserNameRequest : GraphQLRequest
	{

		public GetUserByUserNameRequest(string userName) : base()
		{
			this.Query = @"query GetUserByUserName($userName: String) {
				User(where: {
					UserName: {
						_eq: $userName
					}
				}) {
					Id
					UserName
					FullName
					PasswordHash
					Store {
						Id
						Name
					}
				}
			}";
			this.Variables = new
			{
				UserName = userName
			};
		}

	}
}