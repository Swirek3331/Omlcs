using System;
using System.Collections.Generic;

namespace Omlcs.Structures.Arrays
{
    public static class Fill
    {
        public static void FillAnArray<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }
    }
}
