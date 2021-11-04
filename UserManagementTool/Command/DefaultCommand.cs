using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.Command
{
    public class DefaultCommand : ICommand
    {
        public CommandResult Execute()
        {
            return null;
        }

        public bool IsValid()
        {
            return false;
        }
    }
}
