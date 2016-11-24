using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Больница
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void доктораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Showcase.GroupBoxResize(groupDoctors);
        }

        private void регистраторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Showcase.GroupBoxResize(groupRegistrators);
        }

        private void составлениеРасписанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Showcase.GroupBoxResize(groupSchedule);
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
           Showcase.GroupBoxResize(groupSchedule);
        }
    }
}
