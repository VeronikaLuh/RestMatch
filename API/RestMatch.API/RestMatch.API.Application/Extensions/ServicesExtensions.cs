using System;
using Microsoft.Extensions.DependencyInjection;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Application.Services;

namespace RestMatch.API.Infrastructure.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureAutoMapper(this IServiceCollection services) =>
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<ICuisineTypeService, CuisineTypeService>();
        }
    }
}