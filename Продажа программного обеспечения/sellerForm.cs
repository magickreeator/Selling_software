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
        updateSellerForm updateSellerFrm = new updateSellerForm();
        insertSellerForm insertSellerFrm = new insertSellerForm();

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

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                updateSellerFrm.idsTextBox.Text         = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateSellerFrm.appIDTextBox.Text       = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateSellerFrm.firstNameTextBox.Text   = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateSellerFrm.lastNameTextBox.Text    = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updateSellerFrm.otchestvoTextBox.Text   = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                updateSellerFrm.birthDateTextBox.Text   = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                updateSellerFrm.phoneTextBox.Text       = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                updateSellerFrm.addressTextBox.Text     = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                updateSellerFrm.ShowDialog();
                if (updateSellerFrm.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = Functions.getTableData("seller");
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (insertSellerFrm.ShowDialog() == DialogResult.OK)
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
                    Functions.deleteSellerTableField(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.DataSource = Functions.getTableData("seller");
                }
            }
            else MessageBox.Show("Выберите строку в окне с данными!", "Внимание!");
        }
    }
}
