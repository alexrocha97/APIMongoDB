using mongo.Domain.Entities;

namespace mongo.Domain.Interfaces
{
    public interface IPerfilRepository
    {
        IEnumerable<Perfil> ListarPerfis();
    }
}
