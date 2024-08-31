using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MyDataAccess.MySql
{
    public static class Extensions
    {
        public static void AddEfCore(this IServiceCollection services, string dbWriteConnection)
        {
            services.AddDbContextPool<WriteContext>(options =>
            {
                options.UseNpgsql(dbWriteConnection);
            });

            services.AddScoped<WriteContext>(sp => sp.GetService<WriteContext>());
            
        }
    }
}

