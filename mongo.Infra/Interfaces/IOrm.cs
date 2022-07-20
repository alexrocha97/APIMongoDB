using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace mongo.Infra.Interfaces
{
    public interface IOrm
    {
        IServiceCollection AddOrm(IServiceCollection services, IConfiguration configuration = null);
    }
}
