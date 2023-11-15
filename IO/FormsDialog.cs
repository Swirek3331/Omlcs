using System;
using System.Drawing;
using System.Windows.Forms;

using static System.Windows.Forms.MessageBox;

namespace Omlcs.IO
{
    public static class FormsDialog
    {
        internal static Form inputWindow = new()
        {
            //TODO: size, position, etc.
            ClientSize = new Size(50, 50),
            Text = "Prompt",
            Controls =
            {
                new Label(),
                new TextBox(),
                new Button(),
                new Button(),
            }
        };

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

        //TODO: implement
        private static string Prompt(string name, string label, string defaultText)
        {
            inputWindow.Text = name;
            inputWindow.Controls[0].Text = label;
            inputWindow.Controls[1].Text = defaultText;
        }
    }
}
