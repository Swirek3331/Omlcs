using System;
using System.Collections.Generic;

namespace Omlcs.src.util
{
    public static class Arr
    {
        public static T[] FillAnArray<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }

            return array;
        }

        public static T[,] Fill2DArray<T>(T[,] array, T value)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = value;
                }
            }

            return array;
        }

        public static T[,,] Fill3DArray<T>(T[,,] array, T value)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = value;
                    }
                }
            }

            return array;
        }

        public static T[] CreateAnArray<T>(int size, T value)
        {
            T[] array = new T[size];
            return FillAnArray(array, value);
        }

        public static T[,] Create2DArray<T>(int rows, int cols, T value)
        {
            T[,] array = new T[rows, cols];
            return Fill2DArray(array, value);
        }

        public static T[,,] Create3DArray<T>(int rows, int cols, int depth, T value)
        {
            T[,,] array = new T[rows, cols, depth];
            return Fill3DArray(array, value);
        }

        /// <summary>
        /// Tworzy dwu wymiarową tablice wypełnioną zerami.
        /// </summary>
        /// <param name="rows">Wielkość X</param>
        /// <param name="cols">Wielkość </param>
        /// <returns>Tablice wypełnioną zerami</returns>
        public static int[,] Zeros(int rows, int cols)
        {
            return Create2DArray(rows, cols, 0);
        }

        /// <summary>
        /// Zamienia dwa elementy w tablicy.
        /// </summary>
        /// <typeparam name="T">Trzyszcz</typeparam>
        /// <param name="array">Tablica</param>
        /// <param name="a">Indeks do zamiany</param>
        /// <param name="b">Indek do zamianwy</param>
        public static void Swap<T>(T[] array, int a, int b)
        {
            T temp = array[b];
            array[b] = array[a];
            array[a] = temp;
        }
    }
}
