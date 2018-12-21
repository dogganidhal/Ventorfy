using System;

namespace Ventorfy.Common.Exceptions
{
	public class WrongPasswordException : Exception
	{

		public WrongPasswordException() : base("The password you introduced doesn't match our records")
		{
			
		}
		
	}
}