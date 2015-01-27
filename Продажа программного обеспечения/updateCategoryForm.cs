﻿using System;
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
    public partial class updateCategoryForm : Form
    {
        Func Functions = new Func();

        public updateCategoryForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите изменить данные в базе данных?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Functions.updateCategoryTableData(idcTextBox.Text, nameTextBox.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
