using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.IO
{
    public interface IUserInputManager
    {
        public UserInputResult Handle(string[] input);
    }
}
