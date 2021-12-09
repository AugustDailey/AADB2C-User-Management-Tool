﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.IO
{
    public interface IFileService
    {
        string[] Read(string directory, string file);

        bool Write(string directory, string file, string[] content);
    }
}