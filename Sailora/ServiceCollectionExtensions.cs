using BoatService.Web.DataAccess.Contracts;
using BoatService.Web.DataAccess.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BoatService.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddDbContext<DataContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")))
                .AddScoped(typeof(IDbRepository<>), typeof(DbRepository<>));
        }
    }
}