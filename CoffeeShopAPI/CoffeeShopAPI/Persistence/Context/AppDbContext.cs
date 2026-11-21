using CoffeeShopAPI.Application.Interfaces;
using CoffeeShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopAPI.Persistence.Context
{
    public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options), IUnitOfWork
    {

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<MenuItem> MenuItems => Set<MenuItem>();
        public DbSet<Order> Orders => Set<Order>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            // Customer Configuration
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.Property(c => c.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(c => c.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(c => c.Fullname)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasIndex(c => c.Email)
                    .IsUnique();

                entity.HasMany(c => c.Orders)
                    .WithOne(o => o.Customer)
                    .HasForeignKey(o => o.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // MenuItem Configuration
            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.HasKey(m => m.Id);

                entity.Property(m => m.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(m => m.UnitPrice)
                    .HasPrecision(18, 2)
                    .IsRequired();

                entity.Property(m => m.StockQuantity)
                    .IsRequired();
            });

            // Order Configuration
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.Property(o => o.Quantity)
                    .IsRequired();

                entity.Property(o => o.UnitPrice)
                    .HasPrecision(18, 2)
                    .IsRequired();

                // TotalPrice is calculated in C#, not stored separately.
                entity.Ignore(o => o.TotalPrice);

                entity.HasOne(o => o.MenuItem)
                    .WithMany()
                    .HasForeignKey(o => o.MenuItemId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
