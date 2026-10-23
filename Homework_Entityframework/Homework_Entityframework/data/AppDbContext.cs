using Homework_Entityframework.data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Entityframework.data
{
    public sealed class AppDbContext(DbContextOptions<AppDbContext> opts):DbContext(opts)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
