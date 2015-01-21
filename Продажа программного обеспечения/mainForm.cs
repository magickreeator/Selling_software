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
    public partial class mainForm : Form
    {
        developerForm developerFrm = new developerForm();
        categoryForm categoryFrm = new categoryForm();
        appForm appFrm = new appForm();
        sellerForm sellerFrm = new sellerForm();
        sellingForm sellingFrm = new sellingForm();

        public mainForm()
        {
            InitializeComponent();
        }

        private void developerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (developerFrm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (categoryFrm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }

        }

        private void appButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (appFrm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void sellerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (sellerFrm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }

        }

        private void sellingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (sellingFrm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }

        }
    }
}
