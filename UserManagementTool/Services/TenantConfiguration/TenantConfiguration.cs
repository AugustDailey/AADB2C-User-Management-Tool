using System;
using System.Collections.Generic;
using System.Text;

namespace Services.TenantConfiguration
{
    public class TenantConfiguration
    {
        public string Name { get; set; }
        public string DirectoryId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(DirectoryId) && !string.IsNullOrWhiteSpace(ClientId) && !string.IsNullOrWhiteSpace(ClientSecret);
        }
    }
}
