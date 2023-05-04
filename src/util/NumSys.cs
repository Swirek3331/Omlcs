using System;
using System.Globalization;


namespace Omlcs.src.util
{
    public static class NumSys
    {
        /// <summary>
        /// Zamienia fragment zapisu szesnastkowego na liczbę dziesietną.
        /// </summary>
        /// <param name="hex">Ciąg</param>
        /// <param name="index">Początek</param>
        /// <param name="lenght">Jego długość</param>
        /// <returns>Liczbę dziesietną jako typy byte</returns>
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
