﻿using System;
using System.Collections.Generic;

namespace Omlcs.src.util
{
    public static class Search
    {
        //Nie mam pomysłu na to wszystko jszcze.
        public static bool IsInArray<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return true;
                }
                break;
            }
            return false;
        }
    }
}