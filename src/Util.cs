using System;
using System.Collections.Generic;

namespace Omlcs.src
{
    public class Util
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

        public static T[] ReplaceAnArray<T>(T[] array, T value, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    array[i] = newValue;
                }
            }

            return array;
        }

        public static T[,] Replace2DArray<T>(T[,] array, T value, T newValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j].Equals(value))
                    {
                        array[i, j] = newValue;
                    }
                }
            }

            return array;
        }

        public static T[,,] Replace3DArray<T>(T[,,] array, T value, T newValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k].Equals(value))
                        {
                            array[i, j, k] = newValue;
                        }
                    }
                }
            }

            return array;
        }

        public static int[,] Zeros(int rows, int cols)
        {
            return Create2DArray(rows, cols, 0);
        }
    }
}