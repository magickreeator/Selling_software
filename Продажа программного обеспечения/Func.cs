using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Продажа_программного_обеспечения
{
    class Func
    {
        string connect = global::Продажа_программного_обеспечения.Properties.Settings.Default.Selling_softwareConnectionString;
        public ArrayList getTableData(string TableName)
        {
            SqlConnection cn = new SqlConnection(connect);
            ArrayList Selected = new ArrayList();
            try
            {
                string query = "SELECT * FROM " + TableName + ";";
                cn.Open();
                using (SqlCommand cmdSelected = new SqlCommand(query, cn))
                {
                    using (SqlDataReader klientreader = cmdSelected.ExecuteReader())
                    {
                        foreach (DbDataRecord arrayitem in klientreader)
                        {
                            Selected.Add(arrayitem);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cn.Close();
            }
            return Selected;
        }
    }
}
