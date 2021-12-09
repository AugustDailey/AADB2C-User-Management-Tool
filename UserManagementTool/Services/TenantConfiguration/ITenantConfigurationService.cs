using System;
using System.Collections.Generic;
using System.Text;

namespace Services.TenantConfiguration
{
    public interface ITenantConfigurationService
    {
        TenantConfiguration Load(string name);
        List<TenantConfiguration> LoadAll();
        bool Save(TenantConfiguration configuration);
    }
}
