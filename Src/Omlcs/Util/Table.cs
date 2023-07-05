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
    }
}