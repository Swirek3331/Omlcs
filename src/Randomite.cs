using System;
using System.Drawing;
using System.Windows.Forms;

namespace Omlcs.src
{
    public static class Randomite
    {
        private static Random rand = new Random();

        public static int Rand()
        {
            return rand.Next();
        }

        public static int Rand(int max)
        {
            return rand.Next(max);
        }

        public static int Rand(int min, int max)
        {
            return rand.Next(min, max);
        }

        public static byte RandByte()
        {
            return (byte)rand.Next(0, Byte.MaxValue);
        }

        public static byte RandByte(byte max)
        {
            return (byte)rand.Next(max);
        }

        public static byte RandByte(byte min, byte max)
        {
            return (byte)rand.Next(min, max);
        }

        public static Color RandomColor()
        {
            byte r = RandByte();
            byte g = RandByte();
            byte b = RandByte();

            return Color.FromArgb(r, g, b);
        }

        public static Color RandomColorAlpha()
        {
            byte r = RandByte();
            byte g = RandByte();
            byte b = RandByte();
            byte a = RandByte();

            return Color.FromArgb(a, r, g, b);
        }

        public static Point RandomPosition(int maxX, int maxY)
        {
            int x = Rand(0, maxX);
            int y = Rand(0, maxY);

            return new Point(x, y);
        }

        public static Point RandomPosition(int minX, int minY, int maxX, int maxY)
        {
            int x = Rand(minX, maxX);
            int y = Rand(minY, maxY);

            return new Point(x, y);
        }

        public static Point RandomPosition(ContainerControl control, Control entity)
        {
            int x = Rand(0, control.Width - entity.Width);
            int y = Rand(0, control.Height - entity.Height);

            return new Point(x, y);
        }

        public static Size RandomSize()
        {
            int width = Rand(0, Screen.PrimaryScreen.Bounds.Width);
            int height = Rand(0, Screen.PrimaryScreen.Bounds.Height);

            return new Size(width, height);
        }

        public static Size RandomSize(int min, int max)
        {
            int width = Rand(min, max);
            int height = Rand(min, max);

            return new Size(width, height);
        }

        public static Size RandomSize(int minX, int minY, int maxX, int maxY)
        {
            int width = Rand(minX, maxX);
            int height = Rand(minY, maxY);

            return new Size(width, height);
        }
    }
}