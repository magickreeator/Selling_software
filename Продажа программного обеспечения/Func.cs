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

        //public void updateTableData(string TableName, string param1, string param2, string param3, string param4, string param5)
        //{
        //    try
        //    {
        //        Form15 frm15 = new Form15();
        //        using (SqlConnection conn = new SqlConnection(connect))
        //        {
        //            conn.Open();
        //            using (SqlCommand Update = new SqlCommand("UPDATE Postavchiki SET Naimenovanie=@Naimenovanie,Site=@Site, Adres=@Adres, Kod_postavki=@Kod_postavki WHERE Kod_postavshika=@Kod_postavshika", conn))
        //            {
        //                Update.Parameters.AddWithValue("@Naimenovanie", Naimenovanie);
        //                Update.Parameters.AddWithValue("@Site", Site);
        //                Update.Parameters.AddWithValue("@Kod_postavshika", Kod_postavshika);
        //                Update.Parameters.AddWithValue("@Adres", Adres);
        //                Update.Parameters.AddWithValue("@Kod_postavki", Kod_postavki);
        //                Update.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
