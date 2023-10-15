using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using Omlcs.MathEtc;

namespace Omlcs.Collections
{
    public static class Arrays
    {
        public static T Next<T>(T[] array, T current)
        {
            int index = Array.IndexOf(array, current);
            int lenght = array.Length - 1;
            if (index == -1)
                throw new ArgumentException("The current value is not in the array.");
            else if (index == array.Length - 1)
                return array[0];
            return array[index + 1];
        }

        public static void FillAnArray<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }

        public static void FillAnArray<T>(T[] array, T value, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                array[i] = value;
            }
        }

        public static void FillAnArray(int[] array)
        {
            FillAnArray(array, int.MaxValue);
        }

        public static void FillAnArray(int[] array, int max)
        {
            FillAnArray(array, 0, max);
        }

        public static void FillAnArray(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Randomite.Next(min, max);
            }
        }

        public static void FillAnArray(int[] array, int min, int max, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                array[i] = Randomite.Next(min, max);
            }
        }

        public static void Swap<T>(T[] array, int aIndex, int bIndex)
        {
            T buffer = array[aIndex];
            array[aIndex] = array[bIndex];
            array[bIndex] = buffer;

        }

        public static void Reverse<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Swap(array, i, array.Length - 1 - i);
            }
        }
    }
}
