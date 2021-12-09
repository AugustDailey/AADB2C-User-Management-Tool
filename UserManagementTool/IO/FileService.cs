using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UserManagementTool.IO
{
    public class FileService : IFileService
    {
        public string[] Read(string directory, string file)
        {
            try
            {
                var result = File.ReadAllLines(Path.Combine(directory, file));
                return result;
            } 
            catch (Exception e)
            {
                return new string[0];
            }
        }

        public bool Write(string directory, string file, string[] content)
        {
            try
            {
                File.WriteAllLines(Path.Combine(directory, file), content);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<string[]> ReadAll(string directory)
        {
            List<string[]> configurations = new List<string[]>();

            try
            {
                var files = Directory.GetFiles(directory);
                foreach(var file in files)
                {
                    var content = File.ReadAllLines(file);
                    configurations.Add(content);
                }
            }
            catch (Exception e)
            {
            }

            return configurations;
        }
    }
}
