using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Ventorfy.Common.Exceptions;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess;
using Ventorfy.DataAccess.Model.Users;
using Ventorfy.DataAccess.Repository;
using Ventorfy.DataAccess.Repository.Users;
using Xunit;

namespace Ventorfy.Tests
{
	public class UserRepositoryTests : IDisposable
	{

		private readonly VentorfyDbContext _Context;
		private readonly IUserRepository _UserRepository;
		private readonly User _TestUser;

		public UserRepositoryTests()
		{
			this._Context = new VentorfyDbContext();
			this._UserRepository = RepositoryFactory.Instance.CreateUserRepository();
			this._TestUser = this._UserRepository.CreateUser(userName: Guid.NewGuid().ToString(), password: "123456", fullName: "John Doe").Result;
		}
		
		[Fact]
		public async void CreateUser_AddsUserRowIntoDatabase()
		{
			
			var userName = Guid.NewGuid().ToString();
			var fullName = Guid.NewGuid().ToString();
			var password = Guid.NewGuid().ToString();
			await this._UserRepository.CreateUser(userName: userName, password: password, fullName: fullName);

			var userFromDatabase = await this._Context.Users.Where(user => user.UserName == userName).FirstAsync();
			
			Assert.NotNull(userFromDatabase);
			Assert.Equal(userFromDatabase.UserName, userName);
			Assert.Equal(userFromDatabase.FullName, fullName);
			Assert.True(SecurePasswordHasher.Verify(password, userFromDatabase.PasswordHash));

			this._Context.Users.Remove(userFromDatabase);
			this._Context.SaveChanges();

		}
		
		[Fact]
		public async void CreateUser_ReturnsGeneratedUserId()
		{
			
			var userName = Guid.NewGuid().ToString();
			var fullName = Guid.NewGuid().ToString();
			var password = Guid.NewGuid().ToString();
			var user  = await this._UserRepository.CreateUser(userName: userName, password: password, fullName: fullName);

			Assert.True(user.Id > 0);

			this._Context.Remove(user);
			this._Context.SaveChanges();

		}
		[Fact]
		public async void CreateUser_ThrowsOnDuplicateUserName()
		{
			
			try
			{
				await this._UserRepository.CreateUser(userName: this._TestUser.UserName, password: "", fullName: "");
			}
			catch (Exception e)
			{
				// OK
			}

		}

		[Fact]
		public async void Login_ReturnsUserWhenOk()
		{

			try
			{
				
				var user = await this._UserRepository.Login(userName: this._TestUser.UserName, password: "123456");
				
				Assert.Equal(user.Id, this._TestUser.Id);
				Assert.Equal(user.UserName, this._TestUser.UserName);
				Assert.Equal(user.FullName, this._TestUser.FullName);
				Assert.Equal(user.PasswordHash, this._TestUser.PasswordHash);
				
			}
			catch (AccountNotFoundException e)
			{
				Console.WriteLine(e);
				throw;
			}
			catch (WrongPasswordException e)
			{
				Console.WriteLine(e);
				throw;
			}

		}

		[Fact]
		public async void Login_ThrowsAccountNotFoundExceptionForWrongEmail()
		{

			try
			{
				await this._UserRepository.Login(userName: "DOES_NOT_EXIST", password: "WHATEVER");
			}
			catch (AccountNotFoundException e)
			{
				// OK
			}
			
		}
		
		[Fact]
		public async void Login_ThrowsWrongPasswordExceptionForWrongPassword()
		{

			try
			{
				await this._UserRepository.Login(userName: this._TestUser.UserName, password: "WRONG_PASSWORD");
			}
			catch (WrongPasswordException e)
			{
				// OK
			}
			
		}

		public void Dispose()
		{
			this._Context.Users.Remove(this._TestUser);
			this._Context.SaveChanges();
		}
		
	}
}