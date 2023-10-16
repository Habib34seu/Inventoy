using INV.Application.Contracts;
using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Infrastructure.Context;
using INV.Infrastructure.Repository;
using INV.Infrastructure.Repository.InvRepository.BasicInvRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace INV.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureService(this IServiceCollection services, 
                                                                        IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
             options.UseSqlServer(
                 configuration.GetConnectionString("InvConnectionString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUOMRepository, UOMRepository>();

            return services;
        }
    }
}
