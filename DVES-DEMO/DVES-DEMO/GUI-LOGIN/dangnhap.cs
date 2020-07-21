using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVES_DEMO
{
    public partial class dangnhap : Form
    {
        private int flag;
        private string tendn, mk;
        MySqlDataReader rdr = null;
        MySqlConnection conn = null;
        public dangnhap()
        {
            InitializeComponent();
            
            

            try
            {
                conn = DBUtils.GetDBConnection();
                conn.Open();

                string stm = "SELECT * FROM dveslogin";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    tendn = rdr.GetString("ten");
                    mk = rdr.GetString("matkhau");
                   
                    if (rdr.GetString("ghinho").Equals("1"))
                    {
                        txtDN.Text = tendn;
                        txtMK.Text = mk;
                        chksave.Checked = true;
                    }
                    else { chksave.Checked = false; }
                    
                }
                
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }

            } 
        }

        private void BtnDN_Click(object sender, EventArgs e)
        {
            try
            {
                conn = DBUtils.GetDBConnection();
                conn.Open();
                if (flag.Equals(1))
                {
                    string query1 = "UPDATE dveslogin SET ghinho= '1' WHERE id = 0";
                    MySqlCommand cm1 = new MySqlCommand(query1, conn);

                    cm1.CommandText = query1;
                    //Assign the connection using Connection
                    cm1.Connection = conn;
                    //Execute query
                    cm1.ExecuteNonQuery();
                    //MessageBox.Show("check");  


                }
                else
                {
                    string query2 = "UPDATE dveslogin SET ghinho= '0' WHERE id = 0";
                    MySqlCommand cm2 = new MySqlCommand(query2, conn);

                    cm2.CommandText = query2;
                    //Assign the connection using Connection
                    cm2.Connection = conn;
                    //Execute query
                    cm2.ExecuteNonQuery();
                    // MessageBox.Show("uncheck");
                }

                if (txtDN.Text.Equals(tendn) && txtMK.Text.Equals(mk))
                {
                    this.Hide();
                    giaodienchinh to_gdchinh = new giaodienchinh();
                    to_gdchinh.ShowDialog();
                    this.Close();
                } else { MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !"); }
                
            }
            catch (Exception) { MessageBox.Show("Error"); }
            finally
            {
               
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }

            }



        }

        private void Chksave_CheckedChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (chksave.Checked == true)
                {
                    flag = 1;
                }
                else flag = 0;

            }
            catch (Exception) { MessageBox.Show("Error"); }

                 
        }
    }
}
