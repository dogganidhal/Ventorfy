using System;
using Microsoft.EntityFrameworkCore;
using Ventorfy.DataAccess;

namespace Ventorfy.Cli
{
	class Migrator
	{

		public static void MigrateDatabase()
		{
			using (var context = new VentorfyDbContext())
			{
				var migrations = context.Database.GetMigrations();
				Console.WriteLine(context.Database.GenerateCreateScript());
			}
		}
		
		static void Main(string[] args)
		{
			Migrator.MigrateDatabase();
		}
	}
}