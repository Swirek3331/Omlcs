using System;
using System.Windows.Forms;

using static System.Windows.Forms.MessageBox;

namespace Omlcs.IO
{
    public static class FormsDialog
    {
        public static void Message(string name, string description)
        {
            Show(description, name, MessageBoxButtons.OK);
        }

        public static bool Confirm(string name, string description)
        {
            DialogResult result = Show(name, description);
            if (result == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
    }
}
