using System;
using System.Windows.Forms;

namespace Omlcs.src
{
    public class Msb
    {
        /// <summary>
        /// Funkcja wyświetlająca komunikat.
        /// Zamierzenie było o wyświetlaniu wyniku.
        /// </summary>
        /// <param name="message">Zawartość komunikatu</param>
        public static void Message(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// Funkcja wyświetlająca komunikat.
        /// Stworzone w intencji o wysyłaniu wyniku
        /// </summary>
        /// <param name="title">Tytuł okna</param>
        /// <param name="message">Zawartość pudełka</param>
        public static void Message(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
