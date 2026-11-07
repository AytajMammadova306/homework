
using LibraryAPI.Domain.AppDbContext;
using System;

namespace LibraryAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddDbContext<AppDbContext>();
            var app = builder.Build();


            app.MapControllers();

            app.Run();
        }
    }
}
