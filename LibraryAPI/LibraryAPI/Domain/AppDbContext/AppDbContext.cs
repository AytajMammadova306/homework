using LibraryAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Domain.AppDbContext
{
    public sealed class AppDbContext(
    DbContextOptions<AppDbContext> opts,
    IConfiguration config
) : DbContext(opts)
    {
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reader> Readers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("Default"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(e =>
            {
                e.HasKey(b => b.Id);

                e.Property(b => b.Title)
                    .IsRequired()
                    .HasMaxLength(150);

                e.Property(b => b.Price)
                    .HasColumnType("decimal(10,2)");

                e.HasOne(b => b.Category)
                    .WithMany(c => c.Books)
                    .HasForeignKey(b => b.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Category>(e =>
            {
                e.HasKey(c => c.Id);

                e.Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });
            modelBuilder.Entity<Reader>(e =>
            {
                e.HasKey(r => r.Id);

                e.Property(r => r.Email)
                    .IsRequired()
                    .HasMaxLength(100);
            });

        }
    }
}
