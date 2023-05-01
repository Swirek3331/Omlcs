using System;
using System.Windows.Forms;

namespace Omlcs.src
{
    public static class Msb
    {
        /// <summary>
        /// Wysyła okno dialogwe z wprowadzonym komunikatem.
        /// </summary>
        /// <param name="message">Wiadomość do wyświetlenia</param>
        public static void Message(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// Pokazuję okno dialoowe z wprowadzonym tytułem i komunikatem.
        /// </summary>
        /// <param name="title">Tytuł okna</param>
        /// <param name="message">Zawrtość tekstowa</param>
        public static void Message(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Nie wiem czy to wszystko z `Application.Exit()` będzie działąć na formularze.
        /// <summary>
        /// Manifestuję okno dialogowe z opcjami tak/nie; wyjście z aplikacji.
        /// </summary>
        public static void Close()
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Zamykanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Okno dialogowe z opcjami tak/nie oraz z wymyśloną zawartością tekstową; wyjście z aplikacji.
        /// </summary>
        /// <param name="message">Zawartość tekstowa</param>
        public static void Close(string message)
        {
            DialogResult result = MessageBox.Show(message, "Zamykanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        /// <summary>
        /// Okno zamykające z wymyśloną zawartością tekstową i tytułem.
        /// </summary>
        /// <param name="title">Tytuł okna</param>
        /// <param name="message">Jego zawartość</param>
        public static void Close(string title, string message)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Okno błędu z wprowadzonym komunikatem.
        /// </summary>
        /// <param name="message">Wiadomość</param>
        public static void Error(string message)
        {
            MessageBox.Show(message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Okno błędu z wprowadzonym tytułem i komunikatem.
        /// </summary>
        /// <param name="title">Tytuł</param>
        /// <param name="message">Komunikat</param>
        public static void Error(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}