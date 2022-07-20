using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mongo.Infra.Interfaces;

namespace mongo.Infra.IOC
{
    public static class ResolveOrmIoC
    {
        public static void AdicionarORMIoC<T>(this IServiceCollection services, IConfiguration configuration = null) where T : IOrm, new()
        {
            var ormType = new T();
            ormType.AddOrm(services, configuration);
        }
    }
}
