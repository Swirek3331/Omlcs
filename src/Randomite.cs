using System;
using System.Drawing;
using System.Windows.Forms;

namespace Omlcs.src
{
    public class Randomite
    {
        public static Random rand = new Random();

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

        public static Color RandomColor()
        {
            /* ja bym tu użył  ? : z alfą i coś, ale coś mi piszę IDE, iż trzeba .NETa zaktuailozwać*/
            byte r = (byte)Rand(0, 255);
            byte g = (byte)Rand(0, 255);
            byte b = (byte)Rand(0, 255);

            return Color.FromArgb(r, g, b);
        }

        public static Color RandomColorAlpha()
        {
            byte r = (byte)Rand(0, 255);
            byte g = (byte)Rand(0, 255);
            byte b = (byte)Rand(0, 255);
            byte a = (byte)Rand(0, 255);

            return Color.FromArgb(a, r, g, b);
        }

        public static Point RandomPosition()
        {
            int x = Rand(0, Screen.PrimaryScreen.Bounds.Width);
            int y = Rand(0, Screen.PrimaryScreen.Bounds.Height);

            return new Point(x, y);
        }

        public static Point RandomPosition(int min)
        {
            int x = Rand(min, Screen.PrimaryScreen.Bounds.Width);
            int y = Rand(min, Screen.PrimaryScreen.Bounds.Height);

            return new Point(x, y);
        }

        public static Point RandomPosition(int min, int max)
        {
            int x = Rand(min, max);
            int y = Rand(min, max);

            return new Point(x, y);
        }

        public static Point RandomPosition(Control container)
        {
            int x = Rand(0, container.ClientSize.Width);
            int y = Rand(0, container.ClientSize.Height);

            return new Point(x, y);
        }

        public static Point RandomPosition(int min, Control container)
        {
            int x = Rand(min, container.ClientSize.Width);
            int y = Rand(min, container.ClientSize.Height);

            return new Point(x, y);
        }

        public static Size RandomSize()
        {
            int width = Rand(0, Screen.PrimaryScreen.Bounds.Width);
            int height = Rand(0, Screen.PrimaryScreen.Bounds.Height);

            return new Size(width, height);
        }

        public static Size RandomSize(int min)
        {
            int width = Rand(min, Screen.PrimaryScreen.Bounds.Width);
            int height = Rand(min, Screen.PrimaryScreen.Bounds.Height);

            return new Size(width, height);
        }

        public static Size RandomSize(int min, int max)
        {
            int width = Rand(min, max);
            int height = Rand(min, max);

            return new Size(width, height);
        }

        public static Size RandomSize(Control container)
        {
            int width = Rand(0, container.ClientSize.Width);
            int height = Rand(0, container.ClientSize.Height);

            return new Size(width, height);
        }

        public static Size RandomSize(int min, Control container)
        {
            int width = Rand(min, container.ClientSize.Width);
            int height = Rand(min, container.ClientSize.Height);

            return new Size(width, height);
        }
    }
}