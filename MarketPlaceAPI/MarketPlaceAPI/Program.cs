
using MarketPlaceAPI.Persistance;
using Microsoft.EntityFrameworkCore;
using System;

namespace MarketPlaceAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddDbContext<AppDbContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
            var app = builder.Build();


            app.MapControllers();

            app.Run();
        }
    }
}
