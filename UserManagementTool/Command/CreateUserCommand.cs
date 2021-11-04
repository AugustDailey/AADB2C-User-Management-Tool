using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.Services;

namespace UserManagementTool.Command
{
    public class CreateUserCommand : ICommand
    {
        public IMicrosftGraphApiAdapterService MicrosoftGraphApiAdapterService { get; }
        public CreateUserCommand(IMicrosftGraphApiAdapterService microsoftGraphApiAdapterService)
        {
            MicrosoftGraphApiAdapterService = microsoftGraphApiAdapterService;
        }


        public CommandResult Execute()
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
