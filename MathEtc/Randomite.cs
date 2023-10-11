using System;

namespace Omlcs.MathEtc
{
    public static class Randomite
    {
        private static readonly Random random = new();

        public static double Radnom()
        {
            return random.NextDouble();
        }

        public static int Next(int min, int max)
        {
            return random.Next(min, max);
        }

        public static int Next(int max)
        {
            return random.Next(max);
        }

        public static int Next()
        {
            return random.Next();
        }
    }
}
