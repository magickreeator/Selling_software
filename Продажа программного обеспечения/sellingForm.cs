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
    public partial class sellingForm : Form
    {
        Func Functions = new Func();
        const string tableName = "selling";
        updateSellingForm updateSellingFrm = new updateSellingForm();
        insertSellingForm insertSellingFrm = new insertSellingForm();

        public sellingForm()
        {
            InitializeComponent();
        }

        private void sellingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void sellingForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.getTableData(tableName);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                updateSellingFrm.idssTextBox.Text           = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateSellingFrm.sellingDateTextBox.Text    = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateSellingFrm.amountTextBox.Text         = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateSellingFrm.appIDTextBox.Text          = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updateSellingFrm.idsTextBox.Text            = dataGridView1.CurrentRow.Cells[4].Value.ToString();                
                updateSellingFrm.ShowDialog();
                if (updateSellingFrm.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = Functions.getTableData(tableName);
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (insertSellingFrm.ShowDialog() == DialogResult.OK)
            {
                if (insertSellingFrm.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = Functions.getTableData(tableName);
                }
                this.Show();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить\nвыделенную запись из базы данных?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Functions.deleteSellingTableField(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.DataSource = Functions.getTableData(tableName);
                }
            }
            else MessageBox.Show("Выберите строку в окне с данными!", "Внимание!");
        }
    }
}
