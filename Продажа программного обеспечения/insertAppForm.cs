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
    public partial class insertAppForm : Form
    {
        Func Functions = new Func();

        public insertAppForm()
        {
            InitializeComponent();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Functions.addAppData(idaTextBox.Text, datePublishedTextBox.Text, fileSizeTextBox.Text, softwareVersionTextBox.Text, priceTextBox.Text, descriptionTextBox.Text, recent_changeTextBox.Text, iddTextBox.Text, idcTextBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void insertAppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
