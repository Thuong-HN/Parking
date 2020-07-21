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
    public partial class huyve : Form
    {
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;
        public huyve()
        {
            InitializeComponent();
           
        }
        

        private void Huyve_Load(object sender, EventArgs e)
        {
            

        }

       
        private void Txtten_Enter(object sender, EventArgs e)
        {
            if (txtten.Text == "Nhập tên người dùng")
            {
                txtten.Text = "";
                txtten.ForeColor = Color.Black;
            }
        }

        private void Txtten_Leave(object sender, EventArgs e)
        {
            if (txtten.Text == "")
            {
                txtten.Text = "Nhập tên người dùng";
                txtten.ForeColor = Color.Silver;
            }
        }

        private void Btnxacnhan_Click(object sender, EventArgs e)
        {
            try
            {

                conn = DBUtils.GetDBConnection();
                conn.Open();

                if (conn != null)
                {

                    DialogResult dialogResult = MessageBox.Show("Xóa dữ liệu ?", "Xác nhận xóa người dùng", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string Query = "DELETE FROM dvesdkvethang WHERE ten='" + txtten.Text + "';";
                        MySqlCommand cmdzs = new MySqlCommand(Query, conn);
                        cmdzs.CommandText = Query;
                        cmdzs.Connection = conn;
                        cmdzs.ExecuteNonQuery();


                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    MessageBox.Show("Không có kết nối đến Server !");
                }


            }
            catch (MySqlException ex)
            {
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Lỗi kết nối đến server !");
            }
            finally
            {
               
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                    this.Hide();
                    giaodienchinh to_giaodienchinh = new giaodienchinh();
                    to_giaodienchinh.ShowDialog();
                    this.Close();
                }

            }
           
        }

        private void Picsearch_Click(object sender, EventArgs e)
        {
            try
            {

                conn = DBUtils.GetDBConnection();
                conn.Open();

                if (conn != null)
                {

                    string getdata = "SELECT * FROM dvesdkvethang";
                    MySqlCommand cmdzs = new MySqlCommand(getdata, conn);
                    rdr = cmdzs.ExecuteReader();
                    while (rdr.Read())
                    {

                        if (txtten.Text.Equals(rdr.GetString("ten")))
                        {

                            txtmathe.Text = rdr.GetString("tagid");
                            txtbienso.Text = rdr.GetString("bienso");
                            txtloaixe.Text = rdr.GetString("loaixe");
                            txtngaydk.Text = rdr.GetString("ngaydangky");
                            txtngayhethan.Text = rdr.GetString("ngayhethan");
                            txttien.Text = rdr.GetString("tien");
                            rdr.Close();
                            break;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Không có kết nối đến Server !");
                }


            }
            catch (MySqlException ex)
            {
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Lỗi kết nối đến server !");
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
    }
}
