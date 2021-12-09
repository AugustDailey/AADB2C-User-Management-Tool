using System;
using UserManagementTool.IO;
using UserManagementTool.Models;
using UserManagementTool.Services.MicrosoftGraphApiAdapter;

namespace UserManagementTool.Command
{
    public class AddTenantConfigurationCommand : ICommand
    {

        private ITenantConfigurationService TenantConfigurationService { get; set; }
        private IMicrosftGraphApiAdapterService MicrosoftGraphApiAdapterService { get; set; }

        private TenantConfiguration TenantConfiguration { get; }

        public AddTenantConfigurationCommand(ITenantConfigurationService tenantConfigurationService, IMicrosftGraphApiAdapterService microsftGraphApiAdapterService, 
            string name, string directoryId, string clientId, string clientSecret)
        {
            TenantConfigurationService = tenantConfigurationService;
            MicrosoftGraphApiAdapterService = microsftGraphApiAdapterService;

            TenantConfiguration = new TenantConfiguration
            {
                Name = name,
                DirectoryId = directoryId,
                ClientId = clientId,
                ClientSecret = clientSecret
            };
        }

        public AddTenantConfigurationCommand(ITenantConfigurationService tenantConfigurationService, IMicrosftGraphApiAdapterService microsftGraphApiAdapterService, 
            TenantConfiguration tenantConfiguration)
        {
            TenantConfigurationService = tenantConfigurationService;
            MicrosoftGraphApiAdapterService = microsftGraphApiAdapterService;

            TenantConfiguration = tenantConfiguration;
        }

        public CommandResult Execute()
        {
            var pingResult = MicrosoftGraphApiAdapterService.Ping(TenantConfiguration);
            if (!pingResult.Success)
            {
                return new CommandResult
                {
                    Result = $"The provided tenant configuration (directory id = {TenantConfiguration.DirectoryId}) is invalid. Please re-enter the configuration and try again.",
                    Action = ResultAction.Print
                };
            }

            var saveresult = TenantConfigurationService.Save(TenantConfiguration);
            if (saveresult)
            {
                return new CommandResult
                {
                    Result = $"The provided tenant configuration (directory id = {TenantConfiguration.DirectoryId}) was successfully validated and saved.",
                    Action = ResultAction.Print
                };
            }
            else
            {
                return new CommandResult
                {
                    Result = $"The provided tenant configuration (directory id = {TenantConfiguration.DirectoryId}) was successfully validated, but an error occurred when saving the configuration.",
                    Action = ResultAction.Print
                };
            }
        }

        public bool IsValid()
        {
            return TenantConfiguration.IsValid();
        }
    }
}
