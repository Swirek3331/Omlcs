using System;

namespace Omlcs.src
{

    /// <summary>
    /// Klasa zawierająca różnego rodzaju obiekty matematyczne.
    /// </summary>
    public static class Mathex
    {
        /// <summary>
        /// Liczba pi w postaci <c>float</c>
        /// </summary>
        public static float PI = (float)Math.PI;
        /// <summary>
        /// Liczba Eulera zapisana jako <c>float</c>
        /// </summary>
        public static float E = (float)Math.E;
        /// <summary>
        /// Boska proporcja wyliczona na podstawie ciągu Fibonacciego, zapisana jako <c>float</c>
        /// </summary>
        public static float goldenRatio = (float)Fib(20) / (float)Fib(19);

        /// <summary>
        /// Funkcja wyliczania silni z liczby typu całkowitego n
        /// </summary>
        /// <param name="n">n!</param>
        /// <returns>Wynik silni, zapisany jako <c>long</c></returns>
        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }


        /// <summary>
        /// Funkcja na wyliczanie ciągu Fibonacciego
        /// </summary>
        /// <param name="n">Która liczba ciągu</param>
        /// <returns>Liczbę z ciągu typu <c>long</c></returns>
        public static long Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fib(n - 1) + Fib(n - 2);
        }

        /// <summary>
        /// Wylicza pierwiastek kwadratowy
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Wynik pierwiastkowania, <c>float</c></returns>
        public static float Sqrt(float x)
        {
            return (float)Math.Sqrt(x);
        }
    }
}
