using MongoDB.Bson;

namespace MongoDBAPIC.Models
{
    public class Departamento
    {
        public ObjectId Id { get; set; }
        public int DepartamentoId { get; set; }
        public string Departamentoname { get; set; }
    }
}
