using System;
using Ventorfy.Common.Exceptions;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess.Model.Users;
using Ventorfy.DataAccess.Repository;
using Ventorfy.DataAccess.Repository.Users;
using Xunit;

namespace Ventorfy.Tests
{
	public class UserRepositoryTests
	{

		private readonly IUserRepository _UserRepository;
		private readonly User _TestUser;

		public UserRepositoryTests()
		{
			this._UserRepository = RepositoryFactory.Instance.CreateUserRepository();
			this._TestUser = this._UserRepository.CreateUser(userName: Guid.NewGuid().ToString(), password: "123456", fullName: "John Doe").Result;
		}
		
		[Fact]
		public async void CreateUser_AddsUserRowIntoDatabase()
		{
			
			var userName = Guid.NewGuid().ToString();
			var fullName = Guid.NewGuid().ToString();
			var password = Guid.NewGuid().ToString();
			var user = await this._UserRepository.CreateUser(userName: userName, password: password, fullName: fullName);
			
			Assert.Equal(userName, user.UserName);
			Assert.Equal(fullName, user.FullName);
			Assert.True(SecurePasswordHasher.Verify(password, user.PasswordHash));
			
		}
		
		[Fact]
		public async void CreateUser_ReturnsGeneratedUserId()
		{
			
			var userName = Guid.NewGuid().ToString();
			var fullName = Guid.NewGuid().ToString();
			var password = Guid.NewGuid().ToString();
			var user  = await this._UserRepository.CreateUser(userName: userName, password: password, fullName: fullName);

			Assert.NotNull(user.Id);

		}
		[Fact]
		public async void CreateUser_ThrowsOnDuplicateUserName()
		{
			await Assert.ThrowsAnyAsync<DuplicateUserException>(async () => await this._UserRepository.CreateUser(userName: this._TestUser.UserName, password: "", fullName: ""));
		}

		[Fact]
		public async void Login_ReturnsUserWhenOk()
		{
			var user = await this._UserRepository.Login(userName: this._TestUser.UserName, password: "123456");
				
			Assert.Equal(user.Id, this._TestUser.Id);
			Assert.Equal(user.UserName, this._TestUser.UserName);
			Assert.Equal(user.FullName, this._TestUser.FullName);
			Assert.Equal(user.PasswordHash, this._TestUser.PasswordHash);
		}

		[Fact]
		public async void Login_ThrowsAccountNotFoundExceptionForWrongEmail()
		{
			await Assert.ThrowsAsync<AccountNotFoundException>(async () =>
				await this._UserRepository.Login(userName: "DOES_NOT_EXIST", password: "WHATEVER"));
		}
		
		[Fact]
		public async void Login_ThrowsWrongPasswordExceptionForWrongPassword()
		{
			await Assert.ThrowsAsync<WrongPasswordException>(async () =>
				await this._UserRepository.Login(userName: this._TestUser.UserName, password: "WRONG_PASSWORD"));
		}
		
	}
}