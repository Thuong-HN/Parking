using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DVES_DEMO
{
    public partial class doitaikhoan : Form
    {
        private string tendn, mk;
        
        MySqlConnection conn = null;
        public doitaikhoan()
        {
            InitializeComponent();
        }

        private void Btnql_Click(object sender, EventArgs e)
        {
            this.Hide();
            quanlyadmin to_quanlyadmin = new quanlyadmin();

            to_quanlyadmin.ShowDialog();
            this.Close();
        }

        private void Btnxn_Click(object sender, EventArgs e)
        {
            tendn = txtdoitendn.Text.ToString();
            mk = txtdoimk.Text.ToString();
            conn = DBUtils.GetDBConnection();
            conn.Open();
            
            try
            {
                if (!tendn.Equals("") && !mk.Equals(""))
                {
                    string updateQuery = "UPDATE dveslogin SET ten = '" + tendn + "', matkhau = '" + mk + "',ghinho = '0' WHERE id='0'";
                    MySqlCommand cm1 = new MySqlCommand(updateQuery, conn);
                    cm1.CommandText = updateQuery;                   
                    cm1.Connection = conn;                   
                    cm1.ExecuteNonQuery();

                    MessageBox.Show("Đổi thông tin tài khoản thành công !");
                    
                }
                else
                {
                    MessageBox.Show("Sai cú pháp vui lòng nhập lại !");
                }
            }
            catch (Exception) { MessageBox.Show("Error"); this.Hide();
                quanlyadmin to_quanlyadmin = new quanlyadmin();

                to_quanlyadmin.ShowDialog();
                this.Close();
            }
            finally
            {

                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
                this.Hide();
                quanlyadmin to_quanlyadmin = new quanlyadmin();
                to_quanlyadmin.ShowDialog();
                this.Close();
            }
        }
    }
}
