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
    public partial class sellingForm : Form
    {
        Func Functions = new Func();
        const string tableName = "selling";
        updateSellingForm updateSellingFrm = new updateSellingForm();
        insertSellingForm insertSellingFrm = new insertSellingForm();
        reportForm reportFrm = new reportForm();

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
                updateSellingFrm.idssTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateSellingFrm.sellingDateTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateSellingFrm.amountTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateSellingFrm.appIDTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updateSellingFrm.idsTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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
            rep.Add("<td align=center><b><font size=2>Код продажи</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Дата продажи</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Количество</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Код программы</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Код продавца</font></b></td>");
            rep.Add("</tr>");

            ArrayList trtds = Functions.getTableData(tableName);
            for (int i = 0; i < trtds.Count; i++)
            {
                DbDataRecord rec = trtds[i] as DbDataRecord;
                rep.Add("<tr>");
                rep.Add("<td><font size=2>" + rec["idss"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["sellingDate"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["amount"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["appID"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["ids"].ToString() + "&nbsp;</font></td>");
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

