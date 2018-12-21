using System.Linq;
using Microsoft.EntityFrameworkCore;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess;
using Ventorfy.DataAccess.Repository.Users;
using Xunit;

namespace Ventorfy.Tests
{
	public class UserRepositoryTests
	{

		private readonly VentorfyDbContext _Context = new VentorfyDbContext();
		
		[Fact]
		public async void CreateUser_AddsToDatabase()
		{
			
			var userRepository = new UserRepository(this._Context);
			await userRepository.CreateUser("john.doe", "123456", "John DOE");

			var userFromDatabase = await this._Context.Users.Where(user => user.UserName == "john.doe").FirstAsync();
			
			Assert.NotNull(userFromDatabase);
			Assert.Equal(userFromDatabase.UserName, "john.doe");
			Assert.Equal(userFromDatabase.FullName, "John DOE");
			Assert.True(SecurePasswordHasher.Verify("123456", userFromDatabase.PasswordHash));


		}
	}
}