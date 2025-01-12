using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace StudyBuddyAPI.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<StudyBuddyDbContext>
    {
        public StudyBuddyDbContext CreateDbContext(string[] args)
        {

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<StudyBuddyDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new StudyBuddyDbContext(optionsBuilder.Options);
        }
    }
}
