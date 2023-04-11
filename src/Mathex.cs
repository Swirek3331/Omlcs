using System;

namespace Omlcs.src
{

    /// <summary>
    /// Klasa zawierająca różnego rodzaju obiekty matematyczne.
    /// </summary>
    public class Mathex
    {

        public static float PI = (float)Math.PI;
        public static float E = (float)Math.E;
        public static float goldenRatio = (float)Fib(20) / (float)Fib(19);

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
    }
}