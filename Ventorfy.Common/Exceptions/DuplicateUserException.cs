using System;

namespace Ventorfy.Common.Exceptions
{
	public class DuplicateUserException : Exception
	{

		public DuplicateUserException(string userName) : base($"User {userName} already exists")
		{
			
		}
		
	}
}