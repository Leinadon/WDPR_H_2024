using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace WPR{
    public static class DbContextConfiguration
    {
        public static IServiceCollection AddCustomDbContext(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WPRDbContext>(options =>
                ConfigureDbContext(options, configuration));
            

            return services;
        }

        private static void ConfigureDbContext(
            DbContextOptionsBuilder optionsBuilder,
            IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("MyDatabase");

            optionsBuilder.UseSqlite(connectionString);
            

            // Additional configurations if needed
            // optionsBuilder.EnableSensitiveDataLogging();
            // optionsBuilder.UseLazyLoadingProxies();
            // ...

            // Uncomment the following line if you want to log SQL statements to the console
            // optionsBuilder.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
        }
    }
}