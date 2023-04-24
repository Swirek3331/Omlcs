using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Omlcs.src
{
    public static class Colores
    {
        public static Color HexColor(string hex)
        {
            int offset = (hex[0] == '#') ? 1 : 0;
            
            byte r = ParseHex(hex, 0 + offset, 2 + offset);
            byte g = ParseHex(hex, 2 + offset, 4 + offset);
            byte b = ParseHex(hex, 4 + offset, 6 + offset);

            return Color.FromArgb(r, g, b);
        }

        private static byte ParseHex(string hex, int index, int lenght)
        {
            return byte.Parse(hex.Substring(index, lenght - index), NumberStyles.HexNumber);
        }
    }
}
