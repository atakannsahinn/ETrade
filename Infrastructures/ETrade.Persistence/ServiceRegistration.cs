﻿using Microsoft.EntityFrameworkCore;
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
        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
    }
}
