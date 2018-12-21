using System;
using Microsoft.EntityFrameworkCore;
using Ventorfy.DataAccess;

namespace Ventorfy.Cli
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new VentorfyDbContext(new DbContextOptionsBuilder<VentorfyDbContext>().Options))
			{
				Console.WriteLine("Hello World");
			}
		}
	}
}