using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omlcs.Src.Collections
{
    public class Arrs
    {
        public static void Remove<T>(T[] array, int index)
        {
            T[] arr = new T[array.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    arr[i] = array[i];
                }
            }
        }

        public static void Copy<T>(T[] source, T[] destination, int lenght)
        {
            if (source.Length < lenght || destination.Length < lenght)
            {
                throw new Exception("Lenght is bigger than array");
            }

            for (int i = 0; i < lenght; i++)
            {
                destination[i] = source[i];
            }
        }

        public static T[] ToCopy<T>(T[] source, int lenght)
        {
            T[] copy = new T[lenght];

            Copy(source, copy, lenght);

            return copy;
        }
    }
}
