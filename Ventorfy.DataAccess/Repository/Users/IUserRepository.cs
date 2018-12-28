using System.Collections.Generic;
using System.Threading.Tasks;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Repository.Users
{
	public interface IUserRepository
	{

		Task<User> CreateUser(string userName, string password, string fullName);
		Task<User> Login(string userName, string password);
		Task<ICollection<User>> GetStoreStaffMembers(Store store);

	}
}