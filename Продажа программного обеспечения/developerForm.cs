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
    public partial class developerForm : Form
    {
        Func Functions = new Func();

        public developerForm()
        {
            InitializeComponent();
        }

        private void developerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();          
        }

        private void developerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.getTableData("developer");
        }
    }
}
