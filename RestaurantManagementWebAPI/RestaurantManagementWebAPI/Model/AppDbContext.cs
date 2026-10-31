using Microsoft.EntityFrameworkCore;

namespace RestaurantManagementWebAPI.Model
{
    public sealed class AppDbContext(
    DbContextOptions<AppDbContext> opts,
    IConfiguration config
) : DbContext(opts)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("Default"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(e =>
            {
                e.HasKey(c => c.Id);
                e.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
            });
            modelBuilder.Entity<Product>(e =>
            {
                e.HasKey(p => p.Id);
                e.Property(p => p.Name).IsRequired().HasMaxLength(100);
                e.Property(p => p.Price).HasColumnType("decimal(10,2)");

                e.HasOne(p => p.Category)
                 .WithMany(c => c.Products)
                 .HasForeignKey(p => p.CategoryId)
                 .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Order>(e =>
            {
                e.HasKey(o => o.Id);
                e.Property(o => o.CustomerName).IsRequired().HasMaxLength(100);
                e.Property(o => o.Status).IsRequired().HasMaxLength(30);
            });
            modelBuilder.Entity<OrderItem>(e =>
            {
                e.HasKey(oi => new { oi.OrderId, oi.ProductId }); 

                e.HasOne(oi => oi.Order)
                 .WithMany(o => o.OrderItems)
                 .HasForeignKey(oi => oi.OrderId)
                 .OnDelete(DeleteBehavior.Cascade);

                e.HasOne(oi => oi.Product)
                 .WithMany(p => p.OrderItems)
                 .HasForeignKey(oi => oi.ProductId)
                 .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
