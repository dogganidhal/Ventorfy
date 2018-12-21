using System;

namespace Ventorfy.Common.Exceptions
{
	public class AccountNotFoundException : Exception
	{

		public AccountNotFoundException(string userName) : base($"No account with username '{userName}' is found")
		{
			
		}
		
	}
}