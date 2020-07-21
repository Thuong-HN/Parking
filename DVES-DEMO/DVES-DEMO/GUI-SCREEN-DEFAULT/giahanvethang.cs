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
    public partial class giahanvethang : Form
    {
        private int stcomport, stttagid;
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;
        public giahanvethang()
        {
            InitializeComponent();
            try
            {

                stcomport = giaodienchinh.statuscomport;  // kiểm tra tình trạng kết nối của USB
            }
            catch { }
        }

        private void Btngiahan_Click(object sender, EventArgs e)
        {           
            try
            {
                conn = DBUtils.GetDBConnection();
                conn.Open();

                if (conn != null && !txttagid.Text.Equals(""))
                {
                    string getdata = "SELECT * FROM dvesdkvethang";
                    MySqlCommand cmdzs = new MySqlCommand(getdata, conn);
                    rdr = cmdzs.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (txttagid.Text.Equals(rdr.GetString("tagid")))
                        {
                            txtten.Text = rdr.GetString("ten"); txtbienso.Text = rdr.GetString("bienso");
                            stttagid = 1;
                           
                            rdr.Close();
                            break;
                            
                        }
                        
                    }rdr.Close();

                   
                    DateTime aDateTime = DateTime.Now;
                    txtngaygiahan.Text = aDateTime.ToString();
                    txtngayghtieptheo.Text = aDateTime.AddMonths(1).ToString();

                    if (conn != null && stttagid == 1 )
                    {
                        if (txttien.Text.Equals(""))
                        {
                            MessageBox.Show("Vui lòng nhập số tiền đã thu!");
                        }
                        else
                        {
                            string updateQuery = "UPDATE dvesdkvethang SET ngaydangky = '" + txtngaygiahan.Text + "', ngayhethan = '" + txtngayghtieptheo.Text + "',tien = '" + txttien.Text + "' WHERE tagid = '" + txttagid.Text + "' ";
                            MySqlCommand cmdupdate = new MySqlCommand(updateQuery, conn);
                            cmdupdate.CommandText = updateQuery;
                            cmdupdate.Connection = conn;
                            cmdupdate.ExecuteNonQuery();

                            MessageBox.Show("Gia hạn thành công!");
                        }
                        
                    }
                    
                }else { MessageBox.Show("Không có kết nối đến server hoặc quét thẻ cần gia hạn !"); }




            }
            catch (MySqlException ex)
            {
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Lỗi kết nối đến server !");
            }
            finally
            {
                //MessageBox.Show("**************");
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
                this.Hide();
                giaodienchinh to_giaodienchinh = new giaodienchinh();
                to_giaodienchinh.ShowDialog();
                this.Close();
            }
        }

        private void Giahanvethang_Load(object sender, EventArgs e)
        {

            


        }
    }
}
