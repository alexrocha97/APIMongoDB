using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mongo.Domain.Interfaces;
using mongo.Infra.Data.DbConfiguration;
using mongo.Infra.Data.Mapping;
using mongo.Infra.Data.Repository;
using mongo.Infra.Interfaces;
using mongo.Infra.Settings;

namespace mongo.Infra.IOC.ORMs
{
    public class MongoDbIoC : IOrm
    {
        public IServiceCollection AddOrm(IServiceCollection services, IConfiguration configuration = null)
        {
            IConfigurationSection dbConnectionSettings = AppSettings.GetAppSettingsConfig.GetSection("ConnectionStrings");
            services.Configure<ConnectionStringSettings>(dbConnectionSettings);
            services.AddScoped<IDatabaseFactory, DatabaseFactory>();
            PerfilMap.Configure();
            
            
            services.AddTransient<IPerfilRepository, PerfilRepository>();
            return services;
        }
    }
}
