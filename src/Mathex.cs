using System;

namespace Omlcs.src
{

    public static class Mathex
    {

        public static float PI = (float)Math.PI;
        public static float PI2 = (float)Math.PI * 2;
        public static float PI_2 = (float)Math.PI / 2;
        public static float TAU = PI2;
        public static float E = (float)Math.E;
        public static float PHI = Fib(50) / Fib(49);

        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }


        public static long Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fib(n - 1) + Fib(n - 2);
        }

        public static float Sqrt(float x)
        {
            return (float)Math.Sqrt(x);
        }

        public static int BoolToInt(bool b)
        {
            return b ? 1 : 0;
        }
    }
}