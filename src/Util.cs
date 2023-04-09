using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omlcs.src
{
    public static class Util
    {
        /* Ja tu się jeszcze kiedyś w generics pobawię.
         * Narazie jest jak jest.
         */

        // <sumary>
        // Wypełnia daną talbicę wartością podaną jako argument drugi - od 0 do 255.
        // </sumary>
        public static int[] FillAnArray(int[] array, byte value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }

            return array;
        }

        // <sumary>
        // Wypełnią podaną dwuwymiarową tablicę wartością daną wartością.
        // </sumary>
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


        // <sumary>
        // Wypełnia trójwymiarową tablicę typu int
        // <sumary>
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
    }
}
