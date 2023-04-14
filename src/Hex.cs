using System;
using System.Drawing;
using System.Windows.Forms;

namespace Omlcs.src
{
    public class Hex
    {
        public static byte ParseHex(string hex, int index, int lenght)
        {
            int value = 0;

            for (int i = index; i < lenght; i++)
            {
                value += Util.HexToByte(hex[i]);
            }

            return (byte)value;
        }

        public static Color HexColor(string hex)
        {
            if (hex.Length != 6)
            {
                throw new Exception("Za krótka wartość koloru");
            }

            byte r = ParseHex(hex, 0, 2);
            byte g = ParseHex(hex, 2, 4);
            byte b = ParseHex(hex, 4, 6);

            return Color.FromArgb(r, g, b);
        }
    }
}
