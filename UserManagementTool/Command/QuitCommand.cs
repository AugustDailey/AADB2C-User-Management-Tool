using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.Command
{
    public class QuitCommand : ICommand
    {
        public CommandResult Execute()
        {
            return new CommandResult
            {
                Action = ResultAction.Quit,
                Result = "Application shutting down."
            };
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
