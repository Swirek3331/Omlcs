using System;
using System.Collections.Generic;

namespace Omlcs.IO
{
    public static class Terminal
    {
        public static void Display<T>(IEnumerable<T> structure)
        {
            Display(structure, 0, structure.Count());
        }

        public static void Display<T>(IEnumerable<T> structure, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(structure.ElementAt(i));
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