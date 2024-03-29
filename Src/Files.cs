using System;
using System.IO;

namespace Omlcs
{
    public static class Files
    {
        public static string RootPath()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        }

        public static StreamReader ReadFile(string path)
        {
            return new StreamReader(path);
        }

        public static StreamWriter CreateFile(string path)
        {
            return new StreamWriter(path);
        }
    }
}
