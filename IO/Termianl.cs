using System;

namespace Omlcs.IO
{
    public static class Terminal
    {
        public static void Printf(string text)
        {
            Console.WriteLine(text);
        }

        public static void Printf(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}