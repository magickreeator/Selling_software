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
    public partial class appForm : Form
    {
        insertAppForm insertAppFrm = new insertAppForm();
        updateAppForm updateAppFrm = new updateAppForm();

        Func Functions = new Func();
        const string tableName = "app";

        public appForm()
        {
            InitializeComponent();
        }

        private void appForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void appForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.getTableData(tableName);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (insertAppFrm.ShowDialog() == DialogResult.OK)
            {
                if (insertAppFrm.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = Functions.getTableData(tableName);
                }
                this.Show();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                updateAppFrm.idaTextBox.Text                = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateAppFrm.datePublishedTextBox.Text      = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateAppFrm.fileSizeTextBox.Text           = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateAppFrm.softwareVersionTextBox.Text    = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updateAppFrm.priceTextBox.Text              = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                updateAppFrm.descriptionTextBox.Text        = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                updateAppFrm.recent_changeTextBox.Text      = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                updateAppFrm.iddTextBox.Text                = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                updateAppFrm.idcTextBox.Text                = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                updateAppFrm.ShowDialog();
                if (updateAppFrm.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = Functions.getTableData(tableName);
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить\nвыделенную запись из базы данных?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Functions.deleteAppTableField(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.DataSource = Functions.getTableData(tableName);
                }
            }
            else MessageBox.Show("Выберите строку в окне с данными!", "Внимание!");
        }
    }
}
