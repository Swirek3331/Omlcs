using System;
using System.Drawing;
using System.Windows.Forms;

namespace Omlcs.src.com
{
    public static class Forms
    {
        public static void ShowForm(Form form, Form parrent)
        {
            form.Icon = parrent.Icon;
            form.MdiParent = parrent.MdiParent;
            form.Show();
            form.Activate();
        }
    }
}
