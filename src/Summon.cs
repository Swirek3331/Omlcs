using Omlcs.src;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Omlcs
{
    public class Summon
    {
        public static void RandomMake(Control entity, Control container)
        {
            entity.Size = Randomite.RandomSize(container);
            entity.BackColor = Randomite.RandomColor();
            entity.Location = Randomite.RandomPosition(container, entity);

            container.Controls.Add(entity);
        }

        public static void RandomMake(Control entity, Control container, int width, int height)
        {
            entity.Size = new Size(width, height);
            entity.BackColor = Randomite.RandomColor();
            entity.Location = Randomite.RandomPosition(container, entity);

            container.Controls.Add(entity);
        }
    }
}