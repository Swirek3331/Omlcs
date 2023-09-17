using System;
using System.Collections.Generic;

using static Omlcs.IO.Terminal;

namespace Omlcs.Structures
{
    public static class Arrays
    {
        public static void Show<T>(T[] array)
        {
            foreach (T item in array)
            {
                Printf(item);
            }
        }

        public static void Show<T>(T[] array, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Printf(array[i]);
            }
        }

        public static void Swap<T>(T[] array)
        {
            T temp = array[0];
            array[0] = array[1];
            array[1] = temp;
        }

        public static void Fill<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }
    }
}
