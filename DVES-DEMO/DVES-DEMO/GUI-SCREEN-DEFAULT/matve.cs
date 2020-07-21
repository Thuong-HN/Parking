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
    public partial class matve : Form
    {
        private int stcomport;
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;
        public matve()
        {
            InitializeComponent();
            grthemoi.Visible = false;
            lbmathemoi.Visible = false;
            txtmathemoi.Visible = false;
            lbngaydkmoi.Visible = false;
            txtngaydkmoi.Visible = false;
            try
            {

                stcomport = giaodienchinh.statuscomport;  // kiểm tra tình trạng kết nối của USB
            }
            catch { }
        }

        private void Picsearch_Click(object sender, EventArgs e)
        {
            try
            {

                conn = DBUtils.GetDBConnection();
                conn.Open();

                if (conn != null && !txtten.Equals(""))
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

                            grthemoi.Visible = true;
                            lbmathemoi.Visible = true;
                            txtmathemoi.Visible = true;
                            lbngaydkmoi.Visible = true;
                            txtngaydkmoi.Visible = true;
                            rdr.Close();
                            break;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Không có kết nối đến Server hoặc chưa nhập tên !");
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

        private void Btnxacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                conn = DBUtils.GetDBConnection();
                conn.Open();
                DateTime aDateTime = DateTime.Now;
                txtngaydkmoi.Text = aDateTime.ToString();

                if (conn != null && stcomport.Equals(0) && !txtmathemoi.Text.Equals(""))
                {
                    string updateQuery = "UPDATE dvesdkvethang SET ngaydangky = '" + txtngaydkmoi.Text + "', tagid = '" + txtmathemoi.Text + "' WHERE ten = '" + txtten.Text + "' ";
                    MySqlCommand cmdupdate = new MySqlCommand(updateQuery, conn);
                    cmdupdate.CommandText = updateQuery;
                    cmdupdate.Connection = conn;
                    cmdupdate.ExecuteNonQuery();

                    MessageBox.Show("Đổi thẻ thành công!");

                    
                    conn.Close();
                    conn.Dispose();
                    this.Hide();
                    giaodienchinh to_giaodienchinh = new giaodienchinh();
                    to_giaodienchinh.ShowDialog();
                    this.Close();
                }
                else { MessageBox.Show("Có lỗi, kiểm tra kết nối USB/Server !"); }
            }
            catch (MySqlException ex) { MessageBox.Show("Có lỗi kết nối xãy ra"); }
            
        }

        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            giaodienchinh to_giaodienchinh = new giaodienchinh();
            to_giaodienchinh.ShowDialog();
            this.Close();
        }
    }
}
