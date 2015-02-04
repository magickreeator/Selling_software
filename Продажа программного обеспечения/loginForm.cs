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
        Func Functions = new Func();
        mainForm mainFrm = new mainForm();

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.TextLength != 0 && passwordTextBox.TextLength != 0)
            {
                if (Functions.Autorize(loginTextBox.Text, passwordTextBox.Text))
                {
                    //if (Functions.Administrator(loginTextBox.Text, passwordTextBox.Text)) mainFrm.Admin = true;
                    //else mainFrm.Admin = false;

                    mainFrm.Show();
                    this.Hide();
                    if (mainFrm.DialogResult == DialogResult.OK)
                    {
                        this.Show();
                    }
                }
                else MessageBox.Show("Неверный логин и/или пароль!");
            }
        }
    }
}
