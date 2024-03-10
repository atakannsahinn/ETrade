using Microsoft.EntityFrameworkCore;
using ETrade.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.Application.Repositories.CustomerRepository;
using ETrade.Persistence.Repositories.CustomerRepository;
using ETrade.Application.Repositories.OrderRepository;
using ETrade.Persistence.Repositories.OrderRepository;
using ETrade.Application.Repositories.ProductRepository;
using ETrade.Persistence.Repositories.ProductRepository;

namespace ETrade.Persistence;
public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<ETradeDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
        services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
        services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
        services.AddSingleton<IProductReadRepository, ProductReadRepository>();
        services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
    }
}
