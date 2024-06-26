﻿using System;

namespace Omlcs;

public class Mathex
{

    /*
     * Rounding
     */

    public static int Floor(float x)
    {
        int rest = (int)(x % 1);
        int n = (int)(x - rest);

        return n;
    }

    public static int Round(float x)
    {
        if (x % 1 >= 0.5)
        {
            return Ceil(x);
        }

        return Floor(x);
    }

    public static int Ceil(float x)
    {
        return Floor(x) + 1;
    }

    /*
     * Random
     */

    public static int Next(int min, int max)
    {
        Random random = new();

        return random.Next(min, max);
    }

    public static int Next(int max)
    {
        return Next(0, max);
    }

    public static float Next(float min, float max)
    {
        Random random = new();

        return (float)random.NextDouble() * (max - min) + min;
    }

    public static float Next(float max)
    {
        return Next(0, max);
    }

    /*
     * Conversion
     */

    public static T Abs<T>(T x) where T : IComparable<T>
    {
        if (x.CompareTo(default) < 0)
        {
            dynamic negativeX = x;
            return -negativeX;
        }

        return x;
    }

    //Zrobić to generyczne czy coś
    public static int BoolToInt(bool @bool)
    {
        return @bool ? 1 : 0;
    }

    public static bool NumToBool<T>(T x) where T : IComparable<T>
    {
        return x.CompareTo(default) != 0;
    }

    /*
     * Arythmetic
     */

    public static float Sum(params float[] numbers)
    {
        float sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    public static float Average(params float[] numbers)
    {
        return Sum(numbers) / numbers.Length;
    }

    public static float Median(params float[] numbers)
    {
        Array.Sort(numbers);

        if (numbers.Length % 2 == 0)
        {
            return (numbers[numbers.Length / 2] + numbers[numbers.Length / 2 - 1]) / 2;
        }
        else
        {
            return numbers[numbers.Length / 2];
        }
    }
}
