using Entities.Models;
using Logger.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace AzarSahand_API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
        public static void ConfigureServices(this IServiceCollection services)
        {
            //services.AddScoped<ICurrentUserService, CurrentUserService>();
            //services.AddScoped<IAccountService, AccountService>();
            //services.AddScoped<IBaseInfoService, BaseInfoService>();


        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            //services.AddScoped<ILogHandler, LogHandler>();
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<shahghassemi_SahandAzarContext>(o => o.UseSqlServer(connectionString));

            var logconnectionString = config["ConnectionStrings:LogConnection"];
            services.AddDbContext<shahghassemi_SahandAzarLog_DBContext>(o => o.UseSqlServer(logconnectionString));



        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            //services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
