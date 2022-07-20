namespace mongo.Infra.Data.DbConfiguration
{
    public interface IDataSettings
    {
        // Setando a string no banco de dados
        string MongoDbConnection {get; set;}
    }
}
