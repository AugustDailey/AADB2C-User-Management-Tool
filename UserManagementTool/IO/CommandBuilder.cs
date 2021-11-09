﻿using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.Command;
using UserManagementTool.Services;

namespace UserManagementTool.IO
{
    public class CommandBuilder : ICommandBuilder
    {

        private Dictionary<string, CommandType> CommandMappings { get; set; }
        public IMicrosftGraphApiAdapterService MicrosoftGraphApiAdapterService { get; }

        public CommandBuilder(IMicrosftGraphApiAdapterService microsoftGraphApiAdapterService)
        {
            InitializeMappings();
            MicrosoftGraphApiAdapterService = microsoftGraphApiAdapterService;
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

            if (commandType.Equals(CommandType.Create))
            {
                return new CreateUserCommand(MicrosoftGraphApiAdapterService);
            }
            else if (commandType.Equals(CommandType.Read))
            {
                return new ReadUserCommand(MicrosoftGraphApiAdapterService);
            }
            else if (commandType.Equals(CommandType.Update))
            {
                return new UpdateUserCommand(MicrosoftGraphApiAdapterService);
            }
            else if (commandType.Equals(CommandType.Delete))
            {
                return new DeleteUserCommand(MicrosoftGraphApiAdapterService);
            }

            return new DefaultCommand();
        }
    }
}
