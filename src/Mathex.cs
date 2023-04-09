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
        /// Funkcja wyliczania silni z liczby typu całkowitego n
        /// </summary>
        /// <returns>Wynik silni, zapisany jako <c>long</c></returns>
        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }


        /// <summary>
        /// Funkcja na wyliczanie ciągu fibonacciego
        /// </summary>
        /// <returns>Liczbę z ciągu typu <c>long</c></returns>
        public static long Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
    }
}
