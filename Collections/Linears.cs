using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using Omlcs.MathEtc;

namespace Omlcs.Collections
{
    public static class Linears
    {
        public static T Next<T>(IList<T> structure, T current)
        {
            int index = structure.IndexOf(current);

            if (index == -1)
            {
                throw new ArgumentException("Brak takiego elementu w strukturze.");
            }
            else if (index == structure.Count - 1)
            {
                return structure[0];
            }
            else
            {
                return structure[index + 1];
            }
        }

        public static T Previous<T>(IList<T> structure, T current)
        {
            int index = structure.IndexOf(current);
            
            if (index == -1)
            {
                throw new ArgumentException("Brak takiego elementu w strukturze.");
            }
            else if (index == 0)
            {
                return structure[structure.Count - 1];
            }
            else
            {
                return structure[index - 1];
            }
        }
    }
}
