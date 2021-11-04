using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.Command;

namespace UserManagementTool.IO
{
    public interface ICommandBuilder
    {
        ICommand Build(string[] args);
    }
}
