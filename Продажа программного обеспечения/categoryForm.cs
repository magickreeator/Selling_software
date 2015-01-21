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
    public partial class categoryForm : Form
    {
        Func Functions = new Func();

        public categoryForm()
        {
            InitializeComponent();
        }

        private void categoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void categoryForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.getTableData("category");
        }
    }
}
