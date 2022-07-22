using mongo.Domain.Enums;
using mongo.Domain.ValueObjects;
using MongoDB.Bson;

namespace mongo.Application.ViewModels
{
    public class PerfilDTO
    {
        public ObjectId Id { get; private set; }
        public string PerfilNomeCompleto { get; private set; }
        public string PerfilNome { get; private set; }
        public string PerfilDescricao { get; private set; }
        public EnumCurso Curso { get; private set; }
        public int AnoEspecifico { get; private set; }
        public bool? CicloMeioDeAno { get; private set; }
        public bool SomenteVisualizacao { get; private set; }
        public DateTime? DataInicioVigencia { get; private set; }
        public EnumCategoriaPermissao Categoria { get; private set; }
        public IEnumerable<GrupoAcionador> GruposAcionadores { get; private set; }
        public Dictionary<string, PermissaoDetalhe> Permissoes { get; private set; }
    }
}
