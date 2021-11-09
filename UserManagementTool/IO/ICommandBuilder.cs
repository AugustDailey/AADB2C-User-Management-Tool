using UserManagementTool.Command;

namespace UserManagementTool.IO
{
    public interface ICommandBuilder
    {
        ICommand Build(string[] args);
    }
}
