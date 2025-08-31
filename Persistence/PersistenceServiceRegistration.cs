using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            services.AddDbContext<IdentityContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString(nameof(IdentityContext))));

            services.AddDbContext<BaseDbContext>(options => options.UseNpgsql(connectionString: configuration.GetConnectionString(name: nameof(BaseDbContext))));

            return services;
        }

        public static WebApplication ApplyPersistenceConfigure(this WebApplication app)
        {
            using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                scope.ServiceProvider.GetService<BaseDbContext>()?.Database.Migrate();
                scope.ServiceProvider.GetService<IdentityContext>()?.Database.Migrate();
            }

            return app;
        }
    }
}
