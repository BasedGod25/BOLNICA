using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Больница
{
    class Showcase
    {
        public static void GroupBoxResize(System.Windows.Forms.GroupBox gb)
        {
            gb.Dock = System.Windows.Forms.DockStyle.Fill;
            gb.BringToFront();
        }
    }
}
