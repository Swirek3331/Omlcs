﻿using System;
using System.Collections.Generic;

namespace Omlcs.src.util
{
    public static class Sorting
    {
        //Na razie go tak zrobiłem, ale może później będzie wydajniejszy
        //Wciąż i tak O(n^2)
        //Na chwilę obecną tylko int
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }
    }
}