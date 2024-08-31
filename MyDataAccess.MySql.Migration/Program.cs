using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MyDataAccess.MySql.Migration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = CreateHostBuilder(args).Build();

            using (var scope = builder.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var ctx = services.GetRequiredService<WriteContext>();
                    ctx.Database.Migrate();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                    config.AddEnvironmentVariables();
                }).ConfigureServices((context,services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("PgSql");
                    services.AddDbContext<WriteContext>(options =>
                    
                        options.UseNpgsql(connectionString)
                    );
                });
    }

}

