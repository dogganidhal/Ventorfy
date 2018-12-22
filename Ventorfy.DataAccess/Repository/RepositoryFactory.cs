using Microsoft.EntityFrameworkCore.Storage.Internal;
using Ventorfy.DataAccess.Repository.Users;

namespace Ventorfy.DataAccess.Repository
{
	public class RepositoryFactory
	{
		
		private readonly VentorfyDbContext _Context = new VentorfyDbContext();
		
		private static RepositoryFactory _Instance = new RepositoryFactory();
		public static RepositoryFactory Instance => _Instance;

		private RepositoryFactory()
		{
			
		}

		public IUserRepository CreateUserRepository()
		{
			return new UserRepository(this._Context);
		}
		
	}
}