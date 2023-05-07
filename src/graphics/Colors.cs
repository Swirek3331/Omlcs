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
        public static Color ColorOf(string hex)
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
        
        /// <summary>
        /// Kolor w formacie HSL.
        /// </summary>
        /// <param name="hueDeg">Odcień</param>
        /// <param name="saturation">Saturacja</param>
        /// <param name="lightness">Jasność</param>
        /// <returns>Kolor</returns>
        public static Color ColorOf (int hueDeg, float saturation, float lightness)
        {
            int d = (int)(saturation * (1 - Math.Abs(2 * lightness - 1)));
            int m = (int)(lightness - d / 2);
            int x = (int)(d * (1 - Math.Abs((hueDeg / 60) % 2 - 1)) + m);

            int r, g, b;

            if (hueDeg < 60)
            {
                r = 255 * d + m;
                g = 255 * x + m;
                b = m;
            }
            else if (hueDeg < 120)
            {
                r = 255 * x + m;
                g = 255 * d + m;
                b = m;
            }
            else if (hueDeg < 180)
            {
                r = m;
                g = 255 * d + m;
                b = 255 * x + m;
            }
            else if (hueDeg < 240)
            {
                r = m;
                g = 255 * x + m;
                b = 255 * d + m;
            }
            else if (hueDeg < 300)
            {
                r = 255 * x + m;
                g = m;
                b = 255 * d + m;
            }
            else
            {
                r = 255 * d + m;
                g = m;
                b = 255 * x + m;
            }
            //Będzie prościej kiedyś.

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Kolor w formacie CMYK.
        /// </summary>
        /// <param name="cyan">"Ciekawy niebieski"</param>
        /// <param name="magenta">"Dziwny fioletowy"</param>
        /// <param name="yellow">Żółty</param>
        /// <param name="black">Czarny</param>
        /// <returns>Kolor</returns>
        public static Color ColorOf(int cyan, int magenta, int yellow, int black)
        {
            byte r = (byte)(255 * (1 - cyan) * (1 - black));
            byte g = (byte)(255 * (1 - magenta) * (1 - black));
            byte b = (byte)(255 * (1 - yellow) * (1 - black));

            return Color.FromArgb(r, g, b);
        }
    }
}
