using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.IO;
using UserManagementTool.Services.Configuration;

namespace Services.TenantConfiguration
{
    public class TenantConfigurationService : ITenantConfigurationService
    {
        private IFileService FileServce { get; set; }
        private string TenantConfigurationDirectory { get; set; }
        private string Delimiter { get; set; }

        public TenantConfigurationService(IConfigurationService configurationService, IFileService fileService)
        {
            FileServce = fileService;

            TenantConfigurationDirectory = configurationService.TenantConfigurationDirectory();
            Delimiter = configurationService.TenantConfigurationDelimiter();
        }

        public TenantConfiguration Load(string name)
        {
            var output = FileServce.Read(TenantConfigurationDirectory, $"{name}.txt");
            return Parse(output);
        }

        public List<TenantConfiguration> LoadAll()
        {
            throw new NotImplementedException();
        }

        public bool Save(TenantConfiguration configuration)
        {
            throw new NotImplementedException();
        }

        private TenantConfiguration Parse(string[] lines)
        {
            if (lines.Length < 3)
            {
                return new TenantConfiguration();
            }

            var result = new TenantConfiguration();
            var map = new Dictionary<string, string>();
            foreach(var line in lines)
            {
                var kvpair = line.Split(Delimiter);
                if (kvpair.Length != 2)
                {
                    continue;
                }

                map.Add(kvpair[0], kvpair[1]);
            }

            if (map.TryGetValue("directoryId", out string directoryId))
            {
                result.DirectoryId = directoryId;
            }

            if (map.TryGetValue("clientId", out string clientId))
            {
                result.ClientId = clientId;
            }

            if (map.TryGetValue("clientSecret", out string clientSecret))
            {
                result.ClientSecret = clientSecret;
            }

            return result;
        }
    }
}
