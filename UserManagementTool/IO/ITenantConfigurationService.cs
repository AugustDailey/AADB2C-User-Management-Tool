using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.Models;

namespace UserManagementTool.IO
{
    public interface ITenantConfigurationService
    {
        TenantConfiguration Load(string id);
        List<TenantConfiguration> LoadAll();
        bool Save(TenantConfiguration configuration);
    }
}
