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
    public partial class appForm : Form
    {
        insertAppForm insertAppFrm = new insertAppForm();
        updateAppForm updateAppFrm = new updateAppForm();
        reportForm reportFrm = new reportForm();

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
            rep.Add("<td align=center><b><font size=2>Код программы</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Дата публикации</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Размер файла</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Версия</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Цена</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Описание</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Последние изменения</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Код разработчика</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Код категории</font></b></td>");
            rep.Add("</tr>");

            ArrayList trtds = Functions.getTableData(tableName);
            for (int i = 0; i < trtds.Count; i++)
            {
                DbDataRecord rec = trtds[i] as DbDataRecord;
                rep.Add("<tr>");
                rep.Add("<td><font size=2>" + rec["ida"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["datePublished"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["fileSize"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["softwareVersion"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["price"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["description"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["recent_change"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["idd"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["idc"].ToString() + "&nbsp;</font></td>");
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
