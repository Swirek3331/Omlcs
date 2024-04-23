using System;

namespace Omlcs
{
    public class Math
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

        public static int BoolToInt(bool @bool)
        {
            return @bool ? 1 : 0;
        }

        public static bool IntToBool(int num)
        {
            return num == 1;
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
    }
}
