using System;
using System.Collections.Generic;

namespace Omlcs.src.util
{
    public static class Search
    {
        //Nie mam pomysłu na to wszystko jszcze.

        /// <summary>
        /// Wyszukiwanie liniowe.
        /// Przeszukuję każdy indeks tablicy.
        /// Złożoność czasowa: O(n)
        /// </summary>
        /// <typeparam name="T">Trzyszcz</typeparam>
        /// <param name="array">Tablica do przeszukania</param>
        /// <param name="value">Wartość poszukiwana</param>
        /// <returns>Najbliższy indeks zawierający wartość poszukiwaną. Jeśli nie ma jej nigdzie zwraca -1</returns>
        public static int LinearSearch<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
                break;
            }
            return -1;
        }

        public static int LinearSearch<T>(T[] array, T value, int start)
        {
            for (int i = start; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
                break;
            }
            return -1;
        }

        public static int LinearSearch<T>(T[] array, T value, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
                break;
            }
            return -1;
        }
    }
}
