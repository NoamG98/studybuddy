using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudyBuddyAPI.Data;

public class ProgramEntryPoint
{
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<StudyBuddyDbContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
            });
}
