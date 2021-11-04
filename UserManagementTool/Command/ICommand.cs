using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.Command
{
    public interface ICommand
    {
        bool IsValid();
        CommandResult Execute();
    }
}
