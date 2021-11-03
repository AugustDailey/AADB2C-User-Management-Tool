using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.IO
{
    public interface ICommand
    {
        bool IsValid();
        CommandResult Execute();
    }
}
