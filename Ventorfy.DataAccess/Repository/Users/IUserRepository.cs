using System.Threading.Tasks;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Repository.Users
{
	public interface IUserRepository
	{

		Task<User> CreateUser(string username, string password, string fullName);
		Task<User> Login(string userName, string password);

	}
}