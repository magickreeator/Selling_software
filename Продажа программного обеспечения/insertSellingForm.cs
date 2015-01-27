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
    public partial class insertSellingForm : Form
    {
        Func Functions = new Func();

        public insertSellingForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Functions.addSellingData(idssTextBox.Text, sellingDateTextBox.Text, amountTextBox.Text, appIDTextBox.Text, idsTextBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void insertSellingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
