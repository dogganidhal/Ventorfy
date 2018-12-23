using System.Threading.Tasks;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Repository.Inventory
{
	public interface IStoreRepository
	{

		Task<Store> CreateStore(User admin, string name);
		Task<User> AddStaffMember(Store store, string userName, string fullName, string password);

	}
}