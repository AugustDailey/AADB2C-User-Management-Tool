using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.Services.Configuration
{
    public interface IConfigurationService
    {
        string GraphApiClientId();
        string GraphApiClientSecret();
        string GraphApiDirectoryId();
        string GraphApiScope();
    }
}
