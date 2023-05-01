using System;
using System.Drawing;
using System.Windows.Forms;

namespace Omlcs.src.com
{
    public static class Forms
    {
        public static Icon icon = new Icon("icon.ico");//Nie wiem czy to wyrkyję z /asstes/spirtes.

        public static void ShowForm(Form form, Form parrent)
        {
            form.Icon = parrent.Icon;
            form.MdiParent = parrent.MdiParent;
            form.Show();
            form.Activate();
        }
    }
}
