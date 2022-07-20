using MongoDB.Driver;

namespace mongo.Infra.Data.DbConfiguration
{
    public interface IDatabaseFactory
    {
        IMongoClient GetDbConnectionMongo {get;}
        string GetdbName {get;}
    }
}
