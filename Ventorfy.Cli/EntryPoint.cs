using System;
using System.Collections.Generic;
using GraphQL.Client;
using GraphQL.Common.Request;
using Ventorfy.DataAccess.Model.Inventory;

namespace Ventorfy.Cli
{
	class EntryPoint
	{
		
		static void Main(string[] args)
		{
			var client = new GraphQLClient("https://ventorfy.herokuapp.com/v1alpha1/graphql");
			
			var request = new GraphQLRequest() {
			 Query = @"
				query {
					Store {
						Id
						Name
						Admin {
							Id
							UserName
							PasswordHash
							FullName
						}
						StaffMembers {
							Id
							UserName
							PasswordHash
							FullName
						}
					}
				}"
			};

			var response = client.PostAsync(request).Result;
			var stores = response.GetDataFieldAs<ICollection<Store>>("Store");
			Console.WriteLine(stores);

		}
	}
	
}