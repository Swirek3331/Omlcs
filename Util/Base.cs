using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omlcs.Util
{
    public static class Base
    {
        public static byte HexToByte(string hex, int index, int lenght)
        {
            return byte.Parse(hex.Substring(index, lenght - index), System.Globalization.NumberStyles.HexNumber);
        }
    }
}
