using System;
using System.Collections.Generic;

namespace Omlcs.src
{
    public class Util
    {
        /* 
         * Ja tu się jeszcze kiedyś w generics pobawię.
         * Narazie jest jak jest.
         */
        
        public static int[] FillAnArray(int[] array, byte value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }

            return array;
        }

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

        public static int[] CreateAnArray(byte size, byte value)
        {
            int[] array = new int[size];
            return FillAnArray(array, value);
        }

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