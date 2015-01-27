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
        updateDeveloperForm updateDeveloperFrm = new updateDeveloperForm();
        insertDeveloperForm insertDeveloperFrm = new insertDeveloperForm();

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

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                updateDeveloperFrm.iddTextBox.Text              = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateDeveloperFrm.websiteTextBox.Text          = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateDeveloperFrm.physical_addressTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateDeveloperFrm.emailTextBox.Text            = dataGridView1.CurrentRow.Cells[3].Value.ToString();                
                updateDeveloperFrm.ShowDialog();
                if (updateDeveloperFrm.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = Functions.getTableData("developer");
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (insertDeveloperFrm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить\nвыделенную запись из базы данных?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Functions.deleteDeveloperTableField(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.DataSource = Functions.getTableData("developer");
                }
            }
            else MessageBox.Show("Выберите строку в окне с данными!", "Внимание!");
        }
    }
}
