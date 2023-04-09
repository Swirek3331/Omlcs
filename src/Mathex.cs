using System;

namespace Omlcs.src
{
    public static class Mathex
    {
        public static float PI = (float)Math.PI;
        public static float E = (float)Math.E;

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
    }
}
