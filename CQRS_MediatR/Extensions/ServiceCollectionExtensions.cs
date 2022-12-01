using CQRS_MediatR.Data;
using Microsoft.EntityFrameworkCore;

namespace CQRS_MediatR.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDBMSSql(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
