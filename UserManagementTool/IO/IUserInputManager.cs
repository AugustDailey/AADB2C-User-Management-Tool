﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.IO
{
    public interface IUserInputManager
    {
        UserInputResult Handle(string[] input);
    }
}
