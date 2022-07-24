using BurgerApp.DataAccess.Data;
using BurgerApp.DataAccess.Repositories;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Mappers;
using BurgerApp.Services;
using BurgerApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Helpers
{
    public static class DependecyInjectionHelper
    {
        public static void InjectServices(this IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IBurgerService, BurgerService>();
        }

        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Burger>, BurgerRepository>();
        }

        public static void InjectDbContext(this IServiceCollection services, string connString)
        {
            services.AddDbContext<BurgerAppDbContext>(options =>
                options.UseSqlServer(connString));
        }

        public static void InjectAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(OrderMapper));
            services.AddAutoMapper(typeof(BurgerMapper));
        }

    }
}
