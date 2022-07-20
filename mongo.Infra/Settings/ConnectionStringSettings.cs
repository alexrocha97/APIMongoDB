using mongo.Infra.Data.DbConfiguration;

namespace mongo.Infra.Settings
{
    public class ConnectionStringSettings : IDataSettings
    {
        public string MongoDbConnection {get; set;}
        public string MongoDbDatabase { get; set; }
    }
}
