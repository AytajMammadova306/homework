using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;

namespace SchoolManagementWeb.Model
{
    public sealed class AppDbContext(
    DbContextOptions<AppDbContext> opts,
    IConfiguration config
) : DbContext(opts)
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("Default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(s => s.FullName)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(s => s.Age)
                      .HasColumnType("int");

                entity.HasOne(s => s.Classroom)
                      .WithMany(c => c.Students)
                      .HasForeignKey(s => s.ClassroomId);
            });
            modelBuilder.Entity<Classroom>()
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(c => c.Name)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.HasMany(c => c.Students)
                      .WithMany(s => s.Courses)
                      .UsingEntity<StudentCourse>();
            });

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}
