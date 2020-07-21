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
    public partial class dangnhapADM : Form
    {
        private string tendn, mk;
        MySqlDataReader rdr = null;
        MySqlConnection conn = null;
        public dangnhapADM()
        {
            InitializeComponent();
        }

        private void BtnquaylaiADM_Click(object sender, EventArgs e)
        {
            this.Hide();
            giaodienchinh to_gdchinh = new giaodienchinh();
          
            to_gdchinh.ShowDialog();
            this.Close();
        }

        private void BtnxacnhanADM_Click(object sender, EventArgs e)
        {
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

                    if (txttendnADM.Text.Equals(tendn) && txtmatkhauADM.Text.Equals(mk))
                    {
                        this.Hide();
                        quanlyadmin to_quanlyadmin = new quanlyadmin();

                        to_quanlyadmin.ShowDialog();
                        this.Close();
                    }
                    else { MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !"); }
                }

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
    }
}
