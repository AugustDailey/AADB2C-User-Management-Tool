using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.IO
{
    public class CommandBuilder : ICommandBuilder
    {

        private Dictionary<string, CommandType> CommandMappings { get; set; }

        public CommandBuilder()
        {
            InitializeMappings();
        }

        public void InitializeMappings()
        {
            CommandMappings = new Dictionary<string, CommandType>();
            CommandMappings.Add("create", CommandType.Create);
            CommandMappings.Add("read", CommandType.Read);
            CommandMappings.Add("update", CommandType.Update);
            CommandMappings.Add("delete", CommandType.Delete);
        }


        public ICommand Build(string[] args)
        {
            if (!CommandMappings.TryGetValue(args[0], out var commandType)) {
                return null;
            }

            return new Command();
        }
    }
}
