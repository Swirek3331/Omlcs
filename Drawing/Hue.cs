using System;
using System.Drawing;

using static Omlcs.Util.Base;

namespace Omlcs.Drawing
{
    public static class Hue
    {
        public static Color ColorFrom(string hex)
        {
            int offset = (hex[0] == '#') ? 1 : 0;
            byte red, green, blue;

            red = HexToByte(hex, 0 + offset, 2 + offset);
            green = HexToByte(hex, 2 + offset, 4 + offset);
            blue = HexToByte(hex, 4 + offset, 6 + offset);

            if (hex.Length == 8 + offset)
            {
                byte alpha = HexToByte(hex, 6 + offset, 8 + offset);
                return Color.FromArgb(alpha, red, green, blue);
            }
            else
                return Color.FromArgb(red, green, blue);

        }

        public static string HexFrom(Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }
    }
}
