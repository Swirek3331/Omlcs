using Omlcs.src;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Omlcs
{
    public class Summon
    {
        public static void MakeBox(Control container)
        {
            PictureBox box = new PictureBox
            {
                Size = Randomite.RandomSize(10, 100),
                Location = Randomite.RandomPosition(container),
                BackColor = Randomite.RandomColor()
            };

            container.Controls.Add(box);
        }
    }
}