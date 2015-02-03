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
    public partial class developerForm : Form
    {
        Func Functions = new Func();
        const string tableName = "developer";
        updateDeveloperForm updateDeveloperFrm = new updateDeveloperForm();
        insertDeveloperForm insertDeveloperFrm = new insertDeveloperForm();
        reportForm reportFrm = new reportForm();

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
            dataGridView1.DataSource = Functions.getTableData(tableName);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                updateDeveloperFrm.iddTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateDeveloperFrm.nameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateDeveloperFrm.physical_addressTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateDeveloperFrm.emailTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updateDeveloperFrm.websiteTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                updateDeveloperFrm.ShowDialog();
                if (updateDeveloperFrm.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = Functions.getTableData(tableName);
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (insertDeveloperFrm.ShowDialog() == DialogResult.OK)
            {
                if (insertDeveloperFrm.DialogResult == DialogResult.OK)
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
                    Functions.deleteDeveloperTableField(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
            rep.Add("<td align=center><b><font size=2>Код разработчика</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Название организации</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Физический адрес</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Эл. почта</font></b></td>");
            rep.Add("<td align=center><b><font size=2>Сайт</font></b></td>");
            rep.Add("</tr>");

            ArrayList trtds = Functions.getTableData(tableName);
            for (int i = 0; i < trtds.Count; i++)
            {
                DbDataRecord rec = trtds[i] as DbDataRecord;
                rep.Add("<tr>");
                rep.Add("<td><font size=2>" + rec["idd"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["name"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["physical_address"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["email"].ToString() + "&nbsp;</font></td>");
                rep.Add("<td><p align=center><font size=2>" + rec["website"].ToString() + "&nbsp;</font></td>");
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

