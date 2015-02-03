using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Продажа_программного_обеспечения
{
    public partial class loginForm : Form
    {
        mainForm mainFrm = new mainForm();

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mainFrm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
