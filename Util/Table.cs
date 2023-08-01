using System;
using System.Collections.Generic;

namespace Omlcs.Util
{
    public static class Table
    {
        public static void Swap<T>(T[] array, int a, int b)
        {
            (array[b], array[a]) = (array[a], array[b]);
        }

        public static T NextValue<T>(T[] array, T current)
        {
            int index = Array.IndexOf(array, current);
            //Niestety switch nie chce działać z wartością zmienną.
            if (index == -1)
                throw new ArgumentException("Brak elementu w tablicy");
            else if (index == array.Length - 1)
                return array[0];
            else
                return array[index + 1];
        }

        public static void FillAnArray<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }
    }
}