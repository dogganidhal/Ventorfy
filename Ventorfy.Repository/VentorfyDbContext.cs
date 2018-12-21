using Microsoft.EntityFrameworkCore;
using Ventorfy.Model.Inventory;
using Ventorfy.Model.Orders;
using Ventorfy.Model.Products;
using Ventorfy.Model.Users;
using Ventorfy.Common.Model;

namespace Ventorfy.Repository
{
	public class VentorfyDbContext : DbContext
	{

		public DbSet<User> Users { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<ProductRepo> ProductRepos { get; set; }
		public DbSet<ClientOrder> ClientOrders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<ProviderOrder> ProviderOrders { get; set; }
		public DbSet<Provider> Providers { get; set; }
		public DbSet<Store> Stores { get; set; }

		public VentorfyDbContext(DbContextOptions<VentorfyDbContext> options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL(Configuration.Instance.DbConnectionString);
		}
	}
}