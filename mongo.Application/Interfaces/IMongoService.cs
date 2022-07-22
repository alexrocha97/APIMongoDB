using mongo.Application.ViewModels;

namespace mongo.Application.Interfaces
{
    public interface IMongoService
    {
        Task<IEnumerable<PerfilDTO>> ListarPerfis();
    }
}
