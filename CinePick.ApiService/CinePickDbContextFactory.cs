using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CinePick.ApiService
{
    public class CinePickDbContextFactory : IDesignTimeDbContextFactory<CinePickDbContext>
    {
        public CinePickDbContext CreateDbContext(string[] args)
        {
            Console.WriteLine("DesignTimeDbContextFactory invoked!");
    
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CinePickDbContext>();
            var connStr = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseNpgsql(connStr);

            return new CinePickDbContext(optionsBuilder.Options);
        }


    }
}