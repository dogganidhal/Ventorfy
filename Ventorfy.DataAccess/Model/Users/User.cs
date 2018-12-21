using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Ventorfy.DataAccess.Model.Users
{
	public class User
	{
		
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		[StringLength(64)]
		public string UserName { get; set; }
		
		[Required, StringLength(64)]
		public string FullName { get; set; }
		
		[Required, StringLength(128)]
		public string PasswordHash { get; set; }
		
		public User(string userName, string fullName, string passwordHash)
		{
			UserName = userName;
			FullName = fullName;
			PasswordHash = passwordHash;
		}
		
	}
}