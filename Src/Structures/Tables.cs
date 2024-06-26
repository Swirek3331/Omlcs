﻿using System;

using static Omlcs.Mathex;

namespace Omlcs.Structures;

public class Tables
{
    /*
     * Display
     */


    public static void Display<T>(T[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }

    public static void Display<T>(T[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static void Display<T>(T[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Display(arr[i]);
        }
    }

    public static void DisplayDev<T>(T[] arr)
    {
        string line = "{ Lenght: " + arr.Length;

        for (int i = 0; i < arr.Length; i++)
        {
            line += ", " + i + ": " + arr[i];
        }

        line += " }";

        Console.WriteLine(line);
    }

    //TODO
    public static void DisplayDev<T>(T[,] arr)
    {

    }

    public static void DisplayDev<T>(T[][] arr)
    {
        Console.WriteLine("{ Length: " + arr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
            DisplayDev(arr[i]);
        }

        Console.WriteLine("}");
    }

    /*
     * Create
     */


    public static int[] BuildArray(int x, int min, int max)
    {
        int[] arr = new int[x];

        for (int i = 0; i < x; i++)
        {
            arr[i] = Next(min, max);
        }

        return arr;
    }

    public static int[] BuildArray(int x, int max)
    {
        return BuildArray(x, 0, max);
    }

    public static int[] BuildArray(int x)
    {
        return BuildArray(x, 100);
    }

    public static int[,] BuildArray2D(int x, int y, int min, int max)
    {
        int[,] arr = new int[x, y];

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                arr[i, j] = Next(min, max);
            }
        }

        return arr;
    }

    public static int[,] BuildArray2D(int x, int y, int max)
    {
        return BuildArray2D(x, y, 0, max);
    }

    public static int[,] BuildArray2D(int x, int y)
    {
        return BuildArray2D(x, y, 100);
    }

    public static int[][] BuildArray2DTrue(int x, int y, int min, int max)
    {
        int[][] arr = new int[x][];

        for (int i = 0; i < x; i++)
        {
            arr[i] = BuildArray(y, min, max);
        }

        return arr;
    }

    public static int[][] BuildArray2DTrue(int x, int y, int max)
    {
        return BuildArray2DTrue(x, y, 0, max);
    }

    public static int[][] BuildArray2DTrue(int x, int y)
    {
        return BuildArray2DTrue(x, y, 100);
    }

    /*
     * Fill
     */


    public static void Fill(int[] arr, int min, int max)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Next(min, max);
        }
    }

    public static void Fill(int[] arr, int max)
    {
        Fill(arr, 0, max);
    }

    public static void Fill(int[] arr)
    {
        Fill(arr, 100);
    }

    public static void Fill<T>(T[] arr, T value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = value;
        }
    }

    public static void Fill(int[,] arr, int min, int max)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = Next(min, max);
            }
        }
    }

    public static void Fill(int[,] arr, int max)
    {
        Fill(arr, 0, max);
    }

    public static void Fill(int[,] arr)
    {
        Fill(arr, 100);
    }

    public static void Fill<T>(T[,] arr, T value)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = value;
            }
        }
    }

    public static void Fill(int[][] arr, int min, int max)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Fill(arr[i], min, max);
        }
    }

    public static void Fill(int[][] arr, int max)
    {
        Fill(arr, 0, max);
    }

    public static void Fill(int[][] arr)
    {
        Fill(arr, 100);
    }

    public static void Fill<T>(T[][] arr, T value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Fill(arr[i], value);
        }
    }

    /*
     * To string
     */

    public static string Join<T>(T[] arr, string separator)
    {
        string str = "";

        for (int i = 0; i < arr.Length; i++)
        {
            str += arr[i] + separator;
        }

        return str;
    }

    public static string Join<T>(T[] arr)
    {
        return Join(arr, " ");
    }

    public static string Join<T>(T[,] arr, string separator)
    {
        string str = "";

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                str += arr[i, j] + separator;
            }

            str += Environment.NewLine;
        }

        return str;
    }

    public static string Join<T>(T[,] arr)
    {
        return Join(arr, " ");
    }

    /*
     * Modify
     */

    public static void Swap<T>(ref T[] arr, int i, int j)
    {
        Util.Swap(ref arr[i], ref arr[j]);
    }

    public static void Reverse<T>(ref T[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            Swap(ref arr, i, arr.Length - i - 1);
        }
    }

    /*
     * Conversion
     */

    public static float[] IntToFloatArr(int[] arr)
    {
        float[] floatArr = new float[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            floatArr[i] = arr[i];
        }

        return floatArr;
    }

    public static int[] ToIntArray(string str)
    {
        return ToIntArray(str, " ");
    }

    public static int[] ToIntArray(string str, string seperator)
    {
        string[] strArr = str.Split(seperator);
        int[] arr = new int[strArr.Length];

        for (int i = 0; i < strArr.Length; i++)
        {
            arr[i] = int.Parse(strArr[i]);
        }

        return arr;
    }

    public static float[] ToFloatArray(string str)
    {
        return ToFloatArray(str, " ");
    }

    public static float[] ToFloatArray(string str, string seperator)
    {
        string[] strArr = str.Split(seperator);
        float[] arr = new float[strArr.Length];

        for (int i = 0; i < strArr.Length; i++)
        {
            arr[i] = float.Parse(strArr[i]);
        }

        return arr;
    }

    public static void NormalizeFloor<T>(ref T[][] arr)
    {
        int minLenght = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length < minLenght)
            {
                minLenght = arr[i].Length;
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length != minLenght)
            {
                Array.Resize(ref arr[i], minLenght);
            }
        }
    }


    public static void NormalizeCeil<T>(ref T[][] arr)
    {
        int maxLenght = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length > maxLenght)
            {
                maxLenght = arr[i].Length;
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length < maxLenght)
            {
                Array.Resize(ref arr[i], maxLenght);
                for (int j = arr[i].Length; j < maxLenght; j++)
                {
                    arr[i][j] = default!;
                }
            }
        }
    }

    //TODO
    public static void Normalize<T>(ref T[][] arr)
    {
        int maxLenght = 0;
        int minLenght = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length > maxLenght)
            {
                maxLenght = arr[i].Length;
            }

            if (arr[i].Length < minLenght)
            {
                minLenght = arr[i].Length;
            }
        }
    }

    /*
     * Search
     */

    public static bool Contains(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return true;
            }
        }

        return false;
    }

    public static bool Contains(int[,] arr, int value)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == value)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool Contains(int[][] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (Contains(arr[i], value))
            {
                return true;
            }
        }

        return false;
    }
}
