using Microsoft.Extensions.DependencyInjection;
using mongo.Application.Interfaces;
using AutoMapper;
using mongo.Domain.Entities;
using mongo.Application.ViewModels;
using mongo.Application.Services;

namespace mongo.Application.IoC
{
    public static class ServicesIoC
    {
        public static void ApplicationServicesIoC(this IServiceCollection services)
        {
            services.AddTransient<IMongoService, MongoService>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Perfil, PerfilDTO>().ReverseMap();
                
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
