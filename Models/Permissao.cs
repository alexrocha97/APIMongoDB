using MongoDB.Bson;
using MongoDBAPIC.Enum;
using MongoDBAPIC.Models;

namespace MongoDBAPIC.Models
{
    public class Permissao 
    {
        public ObjectId Id { get; private set;}

        public string PerfilId { get; private set; }

        public EnumAplicacao Aplicacao { get; private set; }

        public Dictionary<string, PermissaoDetalhe> Permissoes { get; private set; }
    }
}
