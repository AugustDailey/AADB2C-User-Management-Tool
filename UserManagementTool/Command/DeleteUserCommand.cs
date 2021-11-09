﻿using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.Services;

namespace UserManagementTool.Command
{
    public class DeleteUserCommand : ICommand
    {
        private IMicrosftGraphApiAdapterService MicrosftGraphApiAdapterService { get; }
        
        private string ObjectId { get; set; }

        public DeleteUserCommand(IMicrosftGraphApiAdapterService microsftGraphApiAdapterService, string objectId)
        {
            MicrosftGraphApiAdapterService = microsftGraphApiAdapterService;

            ObjectId = objectId;
        }

        public CommandResult Execute()
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(ObjectId);
        }
    }
}
