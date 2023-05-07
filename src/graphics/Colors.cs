using System;
using System.Drawing;

using Omlcs.src.util;

namespace Omlcs.src.graphics
{
    public static class Colors
    {

        /// <summary>
        /// Kolor w formacie HEX.
        /// </summary>
        /// <param name="hex">Kolor HEX</param>
        /// <returns>Kolor</returns>
        public static Color ValueOf(string hex)
        {
            int offset = (hex[0] == '#') ? 1 : 0;

            byte r = NumSys.ParseHex(hex, 0 + offset, 2 + offset);
            byte g = NumSys.ParseHex(hex, 2 + offset, 4 + offset);
            byte b = NumSys.ParseHex(hex, 4 + offset, 6 + offset);
            if (hex.Length == 8 + offset)
            {
                byte a = NumSys.ParseHex(hex, 6 + offset, 8 + offset);
                return Color.FromArgb(a, r, g, b);
            }
            else
                return Color.FromArgb(r, g, b);
        }
    }
}
