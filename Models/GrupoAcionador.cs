using MongoDBAPIC.Models;

namespace MongoDBAPIC.Models
{
    public class GrupoAcionador
    {
        public IReadOnlyCollection<Acionador> Acionadores { get; private set; }
    }
}
