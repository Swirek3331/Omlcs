using System;

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

    public static float Random()
    {
        Random random = new();

        return (float)random.NextDouble();
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

    public static int BoolToInt(bool @bool)
    {
        return @bool ? 1 : 0;
    }

    public static bool IntToBool(int n)
    {
        return n == 1;
    }

    /*
     * Arythmetic
     */

    public static float Sum(params float[] arr)
    {
        float sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    public static float Average(params float[] arr)
    {
        return Sum(arr) / arr.Length;
    }

    public static float Median(params float[] arr)
    {
        Array.Sort(arr);

        if (arr.Length % 2 == 0)
        {
            return (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;
        }
        else
        {
            return arr[arr.Length / 2];
        }
    }
}
