using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        //public void updateAppTableData(string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9)
        //{
        //    SqlConnection cn = new SqlConnection(connect);
        //    try
        //    {
        //        cn.Open();
        //        using (SqlCommand Update = new SqlCommand("UPDATE TableName=@TableName SET param2=@param2 WHERE param1=@param1", cn))
        //        {
        //            Update.Parameters.AddWithValue("@param1", param1);
        //            Update.Parameters.AddWithValue("@param2", param2);
        //            Update.ExecuteNonQuery();
        //        }
        //        using (SqlCommand Update = new SqlCommand("UPDATE TableName=@TableName SET param2=@param2, param3=@param3, param4=@param4 WHERE param1=@param1", cn))
        //        {
        //            Update.Parameters.AddWithValue("@param1", param1);
        //            Update.Parameters.AddWithValue("@param2", param2);
        //            Update.Parameters.AddWithValue("@param3", param3);
        //            Update.Parameters.AddWithValue("@param4", param4);
        //            Update.ExecuteNonQuery();
        //        }
        //        using (SqlCommand Update = new SqlCommand("UPDATE TableName=@TableName SET param2=@param2, param3=@param3, param4=@param4, param5=@param5 WHERE param1=@param1", cn))
        //        {
        //            Update.Parameters.AddWithValue("@param1", param1);
        //            Update.Parameters.AddWithValue("@param2", param2);
        //            Update.Parameters.AddWithValue("@param3", param3);
        //            Update.Parameters.AddWithValue("@param4", param4);
        //            Update.Parameters.AddWithValue("@param5", param5);
        //            Update.ExecuteNonQuery();
        //        }
        //        using (SqlCommand Update = new SqlCommand("UPDATE TableName=@TableName SET param2=@param2, param3=@param3, param4=@param4, param5=@param5, param6=@param6, param7=@param7, param8=@param8 WHERE param1=@param1", cn))
        //        {
        //            Update.Parameters.AddWithValue("@param1", param1);
        //            Update.Parameters.AddWithValue("@param2", param2);
        //            Update.Parameters.AddWithValue("@param3", param3);
        //            Update.Parameters.AddWithValue("@param4", param4);
        //            Update.Parameters.AddWithValue("@param5", param5);
        //            Update.Parameters.AddWithValue("@param6", param6);
        //            Update.Parameters.AddWithValue("@param7", param7);
        //            Update.Parameters.AddWithValue("@param8", param8);
        //            Update.ExecuteNonQuery();
        //        }
        //        using (SqlCommand Update = new SqlCommand("UPDATE app SET param2=@param2, param3=@param3, param4=@param4, param5=@param5, param6=@param6, param7=@param7, param8=@param8, param9=@param9 WHERE param1=@param1", cn))
        //        {
        //            Update.Parameters.AddWithValue("@param1", param1);
        //            Update.Parameters.AddWithValue("@param2", param2);
        //            Update.Parameters.AddWithValue("@param3", param3);
        //            Update.Parameters.AddWithValue("@param4", param4);
        //            Update.Parameters.AddWithValue("@param5", param5);
        //            Update.Parameters.AddWithValue("@param6", param6);
        //            Update.Parameters.AddWithValue("@param7", param7);
        //            Update.Parameters.AddWithValue("@param8", param8);
        //            Update.Parameters.AddWithValue("@param9", param9);
        //            Update.ExecuteNonQuery();
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //    //return Selected;
        //}
        public void updateSellingTableData(string param1, string param2, string param3, string param4, string param5)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("UPDATE selling SET sellingDate=@param2, amount=@param3, appID=@param4, ids=@param5 WHERE idss=@param1", conn))
                    {
                        Update.Parameters.AddWithValue("@param1", param1);
                        Update.Parameters.AddWithValue("@param2", param2);
                        Update.Parameters.AddWithValue("@param3", param3);
                        Update.Parameters.AddWithValue("@param4", param4);
                        Update.Parameters.AddWithValue("@param5", param5);
                        Update.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void updateSellerTableData(string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("UPDATE seller SET appID=@param2, firstName=@param3, lastName=@param4, otchestvo=@param5, birthDate=@param6, phone=@param7, address=@param8 WHERE ids=@param1", conn))
                    {
                        Update.Parameters.AddWithValue("@param1", param1);
                        Update.Parameters.AddWithValue("@param2", param2);
                        Update.Parameters.AddWithValue("@param3", param3);
                        Update.Parameters.AddWithValue("@param4", param4);
                        Update.Parameters.AddWithValue("@param5", param5);
                        Update.Parameters.AddWithValue("@param6", param6);
                        Update.Parameters.AddWithValue("@param7", param7);
                        Update.Parameters.AddWithValue("@param8", param8);
                        Update.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void updateAppTableData(string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("UPDATE app SET datePublished=@param2, fileSize=@param3, softwareVersion=@param4, price=@param5, description=@param6, recent_change=@param7, idd=@param8, idc=@param9 WHERE ida=@param1", conn))
                    {
                        Update.Parameters.AddWithValue("@param1", param1);
                        Update.Parameters.AddWithValue("@param2", param2);
                        Update.Parameters.AddWithValue("@param3", param3);
                        Update.Parameters.AddWithValue("@param4", param4);
                        Update.Parameters.AddWithValue("@param5", param5);
                        Update.Parameters.AddWithValue("@param6", param6);
                        Update.Parameters.AddWithValue("@param7", param7);
                        Update.Parameters.AddWithValue("@param8", param8);
                        Update.Parameters.AddWithValue("@param9", param9);
                        Update.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void updateCategoryTableData(string param1, string param2)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("UPDATE category SET name=@param2 WHERE idc=@param1", conn))
                    {
                        Update.Parameters.AddWithValue("@param1", param1);
                        Update.Parameters.AddWithValue("@param2", param2);
                        Update.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void updateDeveloperTableData(string param1, string param2, string param3, string param4)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("UPDATE developer SET website=@param2, physical_address=@param3, email=@param4 WHERE idd=@param1", conn))
                    {
                        Update.Parameters.AddWithValue("@param1", param1);
                        Update.Parameters.AddWithValue("@param2", param2);
                        Update.Parameters.AddWithValue("@param3", param3);
                        Update.Parameters.AddWithValue("@param4", param4);
                        Update.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void deleteAppTableField(string ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("DELETE FROM app WHERE ida=@ID", conn))
                    {
                        Update.Parameters.AddWithValue("@ID", ID);
                        Update.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void deleteCategoryTableField(string ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("DELETE FROM category WHERE idc=@ID", conn))
                    {
                        Update.Parameters.AddWithValue("@ID", ID);
                        Update.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void deleteDeveloperTableField(string ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("DELETE FROM developer WHERE idd=@ID", conn))
                    {
                        Update.Parameters.AddWithValue("@ID", ID);
                        Update.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //public void deleteAppTableField(string ID)
        //{
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connect))
        //        {
        //            conn.Open();
        //            using (SqlCommand Update = new SqlCommand("DELETE FROM app WHERE ida=@ID", conn))
        //            {
        //                Update.Parameters.AddWithValue("@ID", ID);
        //                Update.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
        public void deleteSellerTableField(string ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("DELETE FROM seller WHERE ids=@ID", conn))
                    {
                        Update.Parameters.AddWithValue("@ID", ID);
                        Update.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void deleteSellingTableField(string ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand Update = new SqlCommand("DELETE FROM selling WHERE ida=@ID", conn))
                    {
                        Update.Parameters.AddWithValue("@ID", ID);
                        Update.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void addAppData(string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter add = new SqlDataAdapter("INSERT INTO app ([ida], [datePublished], [fileSize], [softwareVersion], [price], [description], [recent_change], [idd], [idc]) VALUES ('" + param1 + "', ' " + param2 + " ', '" + param3 + "', '" + param4 + "', '" + param5 + "', '" + param6 + "', '" + param7 + "', '" + param8 + "',  '" + param9 + "');", con);
            SqlCommandBuilder comb = new SqlCommandBuilder(add);
            add.Fill(ds);
            con.Close();
        }
        public void addCategoryData(string param1, string param2)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter add = new SqlDataAdapter("INSERT INTO category ([idc], [name]) VALUES ('" + param1 + "', ' " + param2 + "');", con);
            SqlCommandBuilder comb = new SqlCommandBuilder(add);
            add.Fill(ds);
            con.Close();
        }
        public void addDeveloperData(string param1, string param2, string param3, string param4)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter add = new SqlDataAdapter("INSERT INTO developer ([idd], [website], [physical_address], [email]) VALUES ('" + param1 + "', ' " + param2 + " ', '" + param3 + "', '" + param4 + "');", con);
            SqlCommandBuilder comb = new SqlCommandBuilder(add);
            add.Fill(ds);
            con.Close();
        }
        public void addSellerData(string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter add = new SqlDataAdapter("INSERT INTO seller ([ids], [appID], [firstName], [lastName], [otchestvo], [birthDate], [phone], [address]) VALUES ('" + param1 + "', ' " + param2 + " ', '" + param3 + "', '" + param4 + "', '" + param5 + "', '" + param6 + "', '" + param7 + "', '" + param8 + "');", con);
            SqlCommandBuilder comb = new SqlCommandBuilder(add);
            add.Fill(ds);
            con.Close();
        }
        public void addSellingData(string param1, string param2, string param3, string param4, string param5)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter add = new SqlDataAdapter("INSERT INTO selling ([idss], [sellingDate], [amount], [appID], [ids]) VALUES ('" + param1 + "', ' " + param2 + " ', '" + param3 + "', '" + param4 + "', '" + param5 + "');", con);
            SqlCommandBuilder comb = new SqlCommandBuilder(add);
            add.Fill(ds);
            con.Close();
        }
    }
}
