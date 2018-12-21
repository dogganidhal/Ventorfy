using Microsoft.EntityFrameworkCore;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Orders;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess
{
	public class VentorfyDbContext : DbContext
	{

		public DbSet<User> Users { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<ProductLot> ProductLots { get; set; }
		public DbSet<ClientOrder> ClientOrders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<ProviderOrder> ProviderOrders { get; set; }
		public DbSet<Provider> Providers { get; set; }
		public DbSet<Store> Stores { get; set; }

		public VentorfyDbContext() : base(new DbContextOptionsBuilder<VentorfyDbContext>().Options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL("server=localhost;port=8889;user id=root;password=root;database=ventorfy");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasKey(user => user.Id);
		}
	}
}