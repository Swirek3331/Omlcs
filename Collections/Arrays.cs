using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Omlcs.Collections
{
    public static class Arrays
    {
        public static T Next<T>(T[] array, T current)
        {
            int index = Array.IndexOf(array, current);

            if (index == -1)
            {
                throw new ArgumentException("The current value is not in the array.");
            }
            else if (index == array.Length - 1)
            {
                return array[0];
            }
            else
            {
                return array[index + 1];
            }

        }
    }
}
