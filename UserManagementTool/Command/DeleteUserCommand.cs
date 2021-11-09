using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.Services;

namespace UserManagementTool.Command
{
    public class DeleteUserCommand : ICommand
    {
        private IMicrosftGraphApiAdapterService MicrosftGraphApiAdapterService { get; }

        public DeleteUserCommand(IMicrosftGraphApiAdapterService microsftGraphApiAdapterService)
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
