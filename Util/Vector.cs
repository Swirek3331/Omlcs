using System;
using System.Collections.Generic;

namespace Omlcs.Util
{
    public static class Vector
    {
        public static void Swap<T>(List<T> list, int a, int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        public static T Next<T>(List<T> list, T current)
        {
            int index = list.IndexOf(current);

            if (index == -1)
                throw new ArgumentException("Brak elementu w liœcie");
            else if (index == list.Count - 1)
                return list[0];
            else
                return list[index + 1];
        }
    }
}