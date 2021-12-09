using Microsoft.Extensions.Configuration;

namespace UserManagementTool.Services.Configuration
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationSection Configuration;

        public ConfigurationService(IConfiguration config)
        {
            Configuration = config.GetSection("appSettings");
        }


        public string GraphApiClientId()
        {
            return Configuration.GetSection("GraphApiClientId").Value;
        }

        public string GraphApiClientSecret()
        {
            return Configuration.GetSection("GraphApiClientSecret").Value;
        }

        public string GraphApiDirectoryId()
        {
            return Configuration.GetSection("GraphApiDirectoryId").Value;
        }

        public string GraphApiScope()
        {
            return Configuration.GetSection("GraphApiScope").Value;
        }

        public string TenantConfigurationDirectory()
        {
            return Configuration.GetSection("TenantConfigurationDirectory").Value;
        }
    }
}
