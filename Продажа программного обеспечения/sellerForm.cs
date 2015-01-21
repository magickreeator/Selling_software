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
    public partial class sellerForm : Form
    {
        Func Functions = new Func();

        public sellerForm()
        {
            InitializeComponent();
        }

        private void sellerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void sellerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.getTableData("seller");
        }
    }
}
