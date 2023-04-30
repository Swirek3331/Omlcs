using System;
using System.Globalization;


namespace Omlcs.src.util
{
    public static class NumSys
    {
        public static byte ParseHex(string hex, int index, int lenght)
        {
            return byte.Parse(hex.Substring(index, lenght - index), NumberStyles.HexNumber);
        }

        //Będzie tu lepiej i wiecej, ale kiedyś...
        /*
         * > I tyle wamm musi na razie wystarczyć
         * > "kiedyś"
         */
    }
}
