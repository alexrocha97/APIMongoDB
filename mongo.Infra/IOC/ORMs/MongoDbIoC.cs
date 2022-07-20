using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mongo.Infra.Interfaces;
using mongo.Infra.Settings;

namespace mongo.Infra.IOC.ORMs
{
    public class MongoDbIoC : IOrm
    {
        public IServiceCollection AddOrm(IServiceCollection services, IConfiguration configuration = null)
        {
            IConfigurationSection dbConnectionSettings = AppSettings.GetAppSettingsConfig.GetSection("ConnectionStrings");
        
            return services;
        }
    }
}
