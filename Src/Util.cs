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

        public static int[] Build(int x, int min, int max)
        {
            int[] arr = new int[x];

            for (int i = 0; i < x; i++)
            {
                arr[i] = Next(min, max);
            }

            return arr;
        }

        public static int[] Build(int x, int max)
        {
            return Build(x, 0, max);
        }

        public static int[] Build(int x)
        {
            return Build(x, 100);
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

        public static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        public static string Join(int[] arr, string separator)
        {
            string str = "";

            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + separator;
            }

            return str;
        }

        public static string Join(int[] arr)
        {
            return Join(arr, " ");
        }
    }
}
