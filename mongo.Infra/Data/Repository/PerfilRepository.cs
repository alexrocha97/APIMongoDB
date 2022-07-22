using mongo.Domain.Entities;
using mongo.Domain.Interfaces;
using mongo.Infra.Data.Base;
using mongo.Infra.Data.DbConfiguration;

namespace mongo.Infra.Data.Repository
{
    public class PerfilRepository : MongoRepository<Perfil>, IPerfilRepository
    {
        public PerfilRepository(IDatabaseFactory settings) : base(settings, "Perfis")
        { 
        }

        public IEnumerable<Perfil> ListarPerfis()
        {
            var lstPerfis = new List<Perfil>();
            var result = AsQueryable();
            foreach(var perfil in result)
            {
                lstPerfis.Add(perfil);
            }
            return lstPerfis;
        }
    }
}
