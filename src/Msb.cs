using System;
using System.Windows.Forms;

namespace Omlcs.src
{
    public class Msb
    {

        public static void Message(string message)
        {
            MessageBox.Show(message);
        }

        public static void Message(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Close()
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Zamykanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void Close(string message)
        {
            DialogResult result = MessageBox.Show(message, "Zamykanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void Close(string title, string message)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}