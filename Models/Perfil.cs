using MongoDB.Bson;
using MongoDBAPIC.Enum;

namespace MongoDBAPIC.Models
{
    public class Perfil
    {
        public ObjectId Id { get; private set; }
        public string PerfilNomeCompleto { get; private set; }
        public string PerfilNome { get; private set; }
        public string PerfilDescricao { get; private set; }
        public EnumCurso Curso { get; private set; }
        public int Categoria {get; private set;}
        public int AnoEspecifico { get; private set; }
        public bool? CicloMeioDeAno { get; private set; }
        public bool SomenteVisualizacao { get; private set; }
        public DateTime? DataInicioVigencia { get; private set; }
        public IEnumerable<GrupoAcionador> GruposAcionadores { get; private set; }
    }
}
