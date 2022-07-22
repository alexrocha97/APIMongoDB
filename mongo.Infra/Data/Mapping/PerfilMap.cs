using mongo.Domain.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace mongo.Infra.Data.Mapping
{
    public class PerfilMap
    {
        public static void Configure()
        {
            if(!BsonClassMap.IsClassMapRegistered(typeof(Perfil)))
            {
                BsonClassMap.RegisterClassMap<Perfil>(map =>
                {
                    map.MapIdProperty(c => c.Id)
                        .SetIdGenerator(StringObjectIdGenerator.Instance)
                        .SetSerializer(new StringSerializer(BsonType.ObjectId));
                    map.MapMember(x => x.PerfilDescricao);
                    map.MapMember(x => x.PerfilNome);
                    map.MapMember(x => x.CicloMeioDeAno);
                    map.MapMember(x => x.PerfilNomeCompleto);
                    map.MapMember(x => x.Curso);
                    map.MapMember(x => x.GruposAcionadores);
                    map.MapMember(x => x.DataInicioVigencia);
                    map.MapMember(x => x.AnoEspecifico);
                    map.MapMember(x => x.Categoria);
                    map.MapMember(x => x.SomenteVisualizacao);
                });
            }
        }
    }
}
