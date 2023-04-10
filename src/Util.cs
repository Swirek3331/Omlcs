using System;
using System.Collections.Generic;

namespace Omlcs.src
{

    /// <summary>
    /// Przydatne rzeczy
    /// </summary>
    public static class Util
    {
        /* 
         * Ja tu się jeszcze kiedyś w generics pobawię.
         * Narazie jest jak jest.
         */
        
        /// <summary>
        /// Wypełnia tablicę typu int
        /// </summary>
        /// <param name="array">Istniejąca już tablica</param>
        /// <param name="value">Wartość jaką ma być wypełniona</param>
        /// <returns><c>int[]</c> wypełniony podaną wartością</returns>
        public static int[] FillAnArray(int[] array, byte value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }

            return array;
        }

        /// <summary>
        /// Wypełnia dwuwymiarową tablice
        /// </summary>
        /// <param name="array">Dwuwymiarowa tablica typu całkowitego</param>
        /// <param name="value">Wartość jaką ma być wypełniona (byte)</param>
        /// <returns><c>int[,]</c></returns>
        public static int[,] Fill2DArray(int[,] array, byte value)
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

        /// <summary>
        /// Czyde tablica wypełniato-inator
        /// </summary>
        /// <param name="array">Tablica, która ma zostać wypełniona</param>
        /// <param name="value">Wartość</param>
        /// <returns><c>int[,,]</c></returns>
        public static int[,,] Fill3DArray(int[,,] array, byte value)
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

        /// <summary>
        /// Tworzy array wypełniony podaną wartością
        /// </summary>
        /// <param name="size">Rozmiar</param>
        /// <param name="value">Wartość wypełnienia</param>
        /// <returns><c>int[]</c></returns>
        public static int[] CreateAnArray(byte size, byte value)
        {
            int[] array = new int[size];
            return FillAnArray(array, value);
        }

        /// <summary>
        /// Tworzy tablice 2D.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int[,] Create2DArray(byte rows, byte cols, byte value)
        {
            int[,] array = new int[rows, cols];
            return Fill2DArray(array, value);
        }

        public static int[,,] Create3DArray(byte rows, byte cols, byte depth, byte value)
        {
            int[,,] array = new int[rows, cols, depth];
            return Fill3DArray(array, value);
        }

        public static int[,] Zeros(byte rows, byte cols)
        {
            return Create2DArray(rows, cols, 0);
        }
    }
}
