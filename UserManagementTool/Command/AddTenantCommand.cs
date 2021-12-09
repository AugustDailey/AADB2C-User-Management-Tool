using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.Models;
using UserManagementTool.Services.MicrosoftGraphApiAdapter;

namespace UserManagementTool.Command
{
    public class AddTenantCommand : ICommand
    {
        private IMicrosftGraphApiAdapterService MicrosoftGraphApiAdapterService { get; set; }

        private TenantConfiguration TenantConfiguration { get; }

        public AddTenantCommand(IMicrosftGraphApiAdapterService microsftGraphApiAdapterService, string directoryId, string clientId,
            string clientSecret)
        {
            MicrosoftGraphApiAdapterService = microsftGraphApiAdapterService;

            TenantConfiguration = new TenantConfiguration
            {
                DirectoryId = directoryId,
                ClientId = clientId,
                ClientSecret = clientSecret
            };
        }

        public AddTenantCommand(IMicrosftGraphApiAdapterService microsftGraphApiAdapterService, TenantConfiguration tenantConfiguration)
        {
            MicrosoftGraphApiAdapterService = microsftGraphApiAdapterService;

            TenantConfiguration = tenantConfiguration;
        }

        public CommandResult Execute()
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            return TenantConfiguration.IsValid();
        }
    }
}
