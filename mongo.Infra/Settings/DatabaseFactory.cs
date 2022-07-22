using mongo.Infra.Data.DbConfiguration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace mongo.Infra.Settings
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private IOptions<ConnectionStringSettings> connectionStringSettings;
        private string MongoConnection = "MongoDbConnection";
        private string MongoDbDatabase = "MongoDbDatabase";

        public DatabaseFactory(IOptions<ConnectionStringSettings> connectionStringSettings)
        {
            this.connectionStringSettings = connectionStringSettings;
        }

        protected string MongoConnectionString {
            get 
            { 
                var connString = Environment.GetEnvironmentVariable(MongoConnection);

                if (String.IsNullOrEmpty(connString))
                    connString = !string.IsNullOrEmpty(connectionStringSettings.Value.MongoDbConnection) ?
                                                        connectionStringSettings.Value.MongoDbConnection :
                                                        AppSettings.GetAppSettingsConfig.GetConnectionString(MongoConnection);
                return connString;
            }
        }  

        protected string MongoDataBase {
            get
            {
                var db = Environment.GetEnvironmentVariable(MongoDbDatabase);

                if (String.IsNullOrEmpty(db))
                    db = !string.IsNullOrEmpty(connectionStringSettings.Value.MongoDbDatabase) ?
                                                        connectionStringSettings.Value.MongoDbDatabase :
                                                        AppSettings.GetAppSettingsConfig.GetValue<string>(MongoDbDatabase);
                return db;
            }
        }

        public IMongoClient GetDbConnectionMongo => new MongoClient(MongoConnectionString);
        public string GetdbName => MongoDataBase;
    }
}
