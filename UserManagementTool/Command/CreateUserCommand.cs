using System;
using System.Collections.Generic;
using UserManagementTool.Services.MicrosoftGraphApiAdapter;

namespace UserManagementTool.Command
{
    public class CreateUserCommand : ICommand
    {
        private IMicrosftGraphApiAdapterService MicrosoftGraphApiAdapterService { get; }
        private Dictionary<string, object> UserAttributes { get; set; }

        public CreateUserCommand(IMicrosftGraphApiAdapterService microsoftGraphApiAdapterService, Dictionary<string, object> attributes)
        {
            MicrosoftGraphApiAdapterService = microsoftGraphApiAdapterService;

            UserAttributes = attributes;
        }

        public CommandResult Execute()
        {
            throw new NotImplementedException();
        }

        // TODO: Make this more robust
        public bool IsValid()
        {
            return UserAttributes.ContainsKey("signInNames");
        }
    }
}
