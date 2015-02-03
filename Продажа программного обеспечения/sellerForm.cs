using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
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
        const string tableName = "seller";
        reportForm reportFrm = new reportForm();

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
            dataGridView1.DataSource = Functions.getTableData(tableName);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                updateSellerFrm.idsTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateSellerFrm.appIDTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateSellerFrm.firstNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateSellerFrm.lastNameTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updateSellerFrm.otchestvoTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                updateSellerFrm.birthDateTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                updateSellerFrm.phoneTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                updateSellerFrm.addressTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                updateSellerFrm.ShowDialog();
                if (updateSellerFrm.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = Functions.getTableData(tableName);
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (insertSellerFrm.ShowDialog() == DialogResult.OK)
            {
                if (insertSellerFrm.DialogResult == DialogResult.OK)
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
                    Functions.deleteSellerTableField(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.DataSource = Functions.getTableData(tableName);
                }
            }
            else MessageBox.Show("Выберите строку в окне с данными!", "Внимание!");
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList rep = new ArrayList();
            rep.Add("<html>");
            rep.Add("<head>");
            rep.Add("<meta http-qeuiv=\"Content-Language\" content=\"ru\">");
            rep.Add("<meta http-qeuiv=\"Content-Type\" content=\"text/html; charset=windows-1251\">");
            rep.Add("<title>Пример отчета</title>");
            rep.Add("</head>");
            rep.Add("<body>");
            rep.Add("<p align=\"center\"><b>Отчет</b></p>");
            rep.Add("<table border=1 width=100% style\"border-collapse: collapse\" bordercolor=#000 id=\"table1\">");
            rep.Add("<tr>");
            rep.Add("<td align=center><b><font size=2>Код продавца</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Код программы</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Имя</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Фамилия</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Отчество</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Дата рождения</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Телефон</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Адрес</font></b></td>");
            rep.Add("</tr>");

            ArrayList trtds = Functions.getTableData(tableName);
            for (int i = 0; i < trtds.Count; i++)
            {
                DbDataRecord rec = trtds[i] as DbDataRecord;
                rep.Add("<tr>");
                rep.Add("<td><font size=2>" + rec["ids"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["appID"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["firstName"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["lastName"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["otchestvo"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["birthDate"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["phone"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["address"].ToString() + "&nbsp;</font></td>");
                rep.Add("</tr>");
            }
            rep.Add("</table>");
            rep.Add("</body>");
            rep.Add("</html>");
            string filename = Application.StartupPath + "\\report.html";
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.GetEncoding(1251)))
            {
                int i = 0;
                foreach (string record in rep)
                {
                    sw.WriteLine(rep[i].ToString());
                    ++i;
                }
            }
            reportFrm.reportBrowser.Navigate(filename);
            reportFrm.ShowDialog();
        }
    }
}
