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
    public partial class insertSellerForm : Form
    {
        Func Functions = new Func();

        public insertSellerForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Functions.addSellerData(idsTextBox.Text, appIDTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, otchestvoTextBox.Text, birthDateTextBox.Text, phoneTextBox.Text, addressTextBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void insertSellerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
