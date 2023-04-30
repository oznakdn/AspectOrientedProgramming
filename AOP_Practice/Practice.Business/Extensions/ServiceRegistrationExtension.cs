using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Practice.Data.Context;

namespace Practice.Business.Extensions
{
    public static class ServiceRegistrationExtension
    {
        public static void AddDbContextService(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(conf => conf.UseSqlite(connectionString));
        }
    }
}
