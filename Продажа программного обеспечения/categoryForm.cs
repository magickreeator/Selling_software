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
        updateCategoryForm updateCategoryFrm = new updateCategoryForm();
        insertCategoryForm insertCategoryFrm = new insertCategoryForm();

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
            dataGridView1.DataSource = Functions.getTableData("");
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                updateCategoryFrm.idcTextBox.Text   = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateCategoryFrm.nameTextBox.Text  = dataGridView1.CurrentRow.Cells[1].Value.ToString();                
                updateCategoryFrm.ShowDialog();
                if (updateCategoryFrm.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = Functions.getTableData("category");
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (insertCategoryFrm.ShowDialog() == DialogResult.OK)
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
                    //Functions.deleteField(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    dataGridView1.DataSource = Functions.getTableData("category");
                }
            }
            else MessageBox.Show("Выберите строку в окне с данными!", "Внимание!");
        }
    }
}
