using Microsoft.Extensions.Configuration;

namespace mongo.Infra.Settings
{
    public class AppSettings
    {
        public static IConfiguration GetAppSettingsConfig
        {
            get
            {
                IConfigurationRoot Configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                return Configuration;
            }
        }
    }
}
