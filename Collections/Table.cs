using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omlcs.Collections
{
    public static class Table
    {
        public static T[,] Transform<T>(params T[][] array)
        {
            T[,] arr = new T[array.Length, array[0].Length];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    arr[i, j] = array[i][j];
                }
            }

            return arr;
        }
    }
}
