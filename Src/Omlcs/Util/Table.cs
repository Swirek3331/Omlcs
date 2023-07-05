using System;
using System.Collections.Generic;

namespace Omlcs.Util
{
    public static class Table
    {
        public static void Swap<T>(T[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public static T Next<T>(T array[], T current)
        {
            int index = Array.IndexOf(array, current);
            switch (index)
            {
                case -1:
                    throw new ArgumentException();
                case array.Length - 1:
                    return array[0];
                default:
                    return array[index + 1];
            }
        }
    }
}