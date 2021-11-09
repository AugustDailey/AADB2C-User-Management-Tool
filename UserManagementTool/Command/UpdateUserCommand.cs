using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.Services;

namespace UserManagementTool.Command
{
    public class UpdateUserCommand : ICommand
    {
        private IMicrosftGraphApiAdapterService MicrosftGraphApiAdapterService { get; }

        public UpdateUserCommand(IMicrosftGraphApiAdapterService microsftGraphApiAdapterService)
        {
            MicrosftGraphApiAdapterService = microsftGraphApiAdapterService;
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
