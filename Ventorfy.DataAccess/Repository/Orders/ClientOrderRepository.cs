using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Response;
using Newtonsoft.Json.Serialization;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.GraphQL.Mutations;
using Ventorfy.DataAccess.GraphQL.Queries;
using Ventorfy.DataAccess.Model.Orders;

namespace Ventorfy.DataAccess.Repository.Orders
{
	public class ClientOrderRepository : GraphQLRepository, IClientOrderRepository
	{
		
		public ClientOrderRepository(GraphQLClient client) : base(client)
		{
		}
		
		public async Task<ICollection<OrderItem>> CreateOrderItems(ICollection<OrderItem> items)
		{

			var insertionTasks = new List<Task>();
			var responses = new List<GraphQLResponse>();

			foreach (var item in items)
			{
				var request = GraphQLMutationManager.GetMutationRequest(
					GraphQLMutationManager.MutationRequest.InsertClientOrderItem,
					new
					{
						ProductId = item.Product.Id,
						Count = item.Count
					});
				insertionTasks.Add(Task.Run(async () => { responses.Add(await this._Client.PostAsync(request)); }));
			}

			await Task.WhenAll(insertionTasks.ToArray());
			
			var orderItems = new List<OrderItem>();

			foreach (var response in responses)
				orderItems.Add(response.GetDataFieldAs<InsertResult<OrderItem>>("insert_ClientOrderItem").Result.First());

			return orderItems;

		}

		public async Task<ClientOrder> SubmitClientOrder(Guid authorId, ICollection<OrderItem> items)
		{

			var insertClientOrderRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.InsertOrderClient, new
				{
					AuthorId = authorId
				});

			var insertClientOrderResponse = await this._Client.PostAsync(insertClientOrderRequest);
			var clientOrder = insertClientOrderResponse.GetDataFieldAs<InsertResult<ClientOrder>>("insert_ClientOrder").Result.First();

			var updateTasks = new List<Task>();
			var updateResponses = new List<GraphQLResponse>();

			foreach (var orderItem in items)
			{
				var updateClientOrderItemRequest = GraphQLMutationManager.GetMutationRequest(
					GraphQLMutationManager.MutationRequest.UpdateClientOrderItem_SetClientOrder, new
					{
						Id = orderItem.Id,
						ClientOrderId = clientOrder.Id
					});
				updateTasks.Add(Task.Run(async () =>
				{
					updateResponses.Add(await this._Client.PostAsync(updateClientOrderItemRequest));
				}));
				
			}

			await Task.WhenAll(updateTasks.ToArray());

			foreach (var response in updateResponses)
			{
				var orderItem = response.GetDataFieldAs<InsertResult<OrderItem>>("update_ClientOrderItem").Result.First();
				if (clientOrder.Items == null)
				{
					clientOrder.Items = new List<OrderItem>();
				}
				clientOrder.Items.Add(orderItem);
			}

			return clientOrder;

		}

		public async Task<ICollection<ClientOrder>> SelectOrders(Guid storeId, ClientOrderFilter filter)
		{

			var request = GraphQLQueryManager.GetQueryRequest(GraphQLQueryManager.QueryRequest.GetClientOrdersForStore, new
			{
				StoreId = storeId
			});

			var response = await this._Client.PostAsync(request);
			var results = response.GetDataFieldAs<ICollection<ClientOrder>>("ClientOrder");

			return results.Where(order => filter(order)).ToList();

		}
	}
}