using System;
using System.Collections.Generic;

namespace Omlcs.Util
{
    public static class Table
    {
        public static void Swap<T>(T[] array, int a, int b)
        {
            T temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public static T Next<T>(T[] array, T current)
        {
            int index = Array.IndexOf(array, current);
            //Niestety switch nie chce działać z wartością zmienną.
            if (index == -1)
                throw new ArgumentException("Brak elementu w tablicy");
            if (index == array.Length - 1)
                return array[0];
            else
                return array[index + 1];
        }
    }
}