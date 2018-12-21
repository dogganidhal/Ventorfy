using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ventorfy.Common.Exceptions;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Repository.Users
{
	public class UserRepository : IUserRepository
	{

		private readonly VentorfyDbContext _Context;

		public UserRepository(VentorfyDbContext context)
		{
			this._Context = context;
		}
		
		public async Task<User> CreateUser(string username, string password, string fullName)
		{
			var user = new User(username, fullName, SecurePasswordHasher.Hash(password));
			var entityEntry = await this._Context.Users.AddAsync(user);
			await this._Context.SaveChangesAsync();
			return entityEntry.Entity;
		}

		public async Task<User> Login(string userName, string password)
		{
			try
			{
				var user = await this._Context.Users.Where(u => u.UserName == userName).FirstAsync();
				if (SecurePasswordHasher.Verify(password, user.PasswordHash))
					return user;
			}
			catch (Exception)
			{
				throw new AccountNotFoundException(userName);
			}
			throw new WrongPasswordException();
		}
		
	}
}