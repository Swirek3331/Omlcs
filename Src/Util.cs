using System;
using System.IO;

namespace Omlcs
{
    public class Util
    {
        public static int Floor(float x)
        {
            int rest = (int)(x % 1);
            int n = (int)(x - rest);

            return n;
        }

        public static int Round(float x)
        {
            int n;

            if (x % 1 >= 0.5)
            {
                n = Ceil(x);
            }
            else
            {
                n = Floor(x);
            }

            return n;
        }

        public static int Ceil(float x)
        {
            return Floor(x) + 1;
        }

        public static string RootPath()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        }

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

        public static void Display<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

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

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref int[] arr, int i, int j)
        {
            Swap(ref arr[i], ref arr[j]);
        }

        public static void Reverse(ref int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Swap(ref arr, i, arr.Length - i - 1);
            }
        }

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
        
        public static float[] IntToFloatArr(int[] arr)
        {
            float[] floatArr = new float[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                floatArr[i] = arr[i];
            }

            return floatArr;
        }

        public static int BoolToInt(bool @bool)
        {
            return @bool ? 1 : 0;
        }

        public static bool IntToBool(int num)
        {
            return num == 1;
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

        public static void Line(int lenght)
        {
            string line = "";

            for (int i = 0; i < lenght; i++)
            {
                if (i % 2 == 0)
                {
                    line += "-";
                }
                else
                {
                    line += "=";
                }
            }

            Console.WriteLine(line);
        }

        public static void Line()
        {
            Line(25);
        }
    }
}
