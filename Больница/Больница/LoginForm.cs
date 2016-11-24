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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "manager")
            {
                ManagerForm f1 = new ManagerForm();
                f1.Show();
            }
            if (textBox1.Text == "doctor")
            {
                DoctorForm f1 = new DoctorForm();
                f1.Show();
            }
            if (textBox1.Text == "registrator")
            {
                RegistratorForm f1 = new RegistratorForm();
                f1.Show();
            }
        }
    }
}
