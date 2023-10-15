using System;
using System.Collections.Generic;

namespace Omlcs.IO
{
    public static class Terminal
    {
        public static void Printf(object text)
        {
            Console.WriteLine(text);
        }

        public static string? Readf()
        {
            return Console.ReadLine();
        }

        public static void Display<T>(T[] array)
        {
            Display(array, 0, array.Length);
        }

        public static void Display<T>(IEnumerable<T> values, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(values.ElementAt(i);
            }
        }

        public static void ReverseDisplay<T>(T[] array)
        {
            ReverseDisplay(array, 0, array.Length - 1);
        }

        public static void ReverseDisplay<T>(T[] array, int start, int end)
        {
            for (int i = end; i >= start; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}