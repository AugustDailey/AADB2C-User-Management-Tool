using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.IO
{
    public interface ICommandBuilder
    {
        ICommand Build(string[] args);
    }
}
