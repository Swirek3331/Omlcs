using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omlcs.Util
{
    public static class Randomite
    {
        private readonly static Random random = new Random();

        public static int NextInt()
        {
            return random.Next();
        }

        public static int NextInt(int max)
        {
            return random.Next(max);
        }

        public static int NextInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public static byte NextByte()
        {
            return (byte)random.Next(0, 256);
        }

        public static byte NextByte(byte max)
        {
            return (byte)random.Next(max);
        }

        public static byte NextByte(byte min, byte max)
        {
            return (byte)random.Next(min, max);
        }

        public static double NextDouble()
        {
            return random.NextDouble();
        }

        public static Color NextColor()
        {
            return Color.FromArgb(NextByte(), NextByte(), NextByte());
        }
    }
}
