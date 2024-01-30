using System;
using System.IO;

namespace Omlcs.Src.Files
{
    public static class Path
    {
        public static string ProjectDirectory = GetProjectDirectory();

        public static string GetProjectDirectory()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName;

            return projectDirectory + "/";
        }

        public static string GetProjectDirectory(string name)
        {
            if (name[0] == '/')
            {
                name = name.Split('/')[1];
            }

            return GetProjectDirectory() + name;
        }
    }
}
