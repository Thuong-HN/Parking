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
    
    public partial class truyxuat : Form

    {
        private string giovaonhap, giovaolay;
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;
        public truyxuat()
        {
            InitializeComponent();
        }
        private void Truyxuat_Load(object sender, EventArgs e)
        {
            lbvao.Visible = false;picvao.Visible = false;lbra.Visible = false;picra.Visible = false;
        }
        private void Picsearch_Click(object sender, EventArgs e)
        {
            try
            {

                conn = DBUtils.GetDBConnection();
                conn.Open();

                if (conn != null && !txtbienso.Text.Equals("") && !giovaonhap.Equals(""))
                {

                    string getdata = "SELECT * FROM dvesvetrongngay";
                    MySqlCommand cmdzs = new MySqlCommand(getdata, conn);
                    rdr = cmdzs.ExecuteReader();
                    while (rdr.Read())
                    {
                       // MessageBox.Show(rdr.GetString("bienso"));
                        if (txtbienso.Text.Equals(rdr.GetString("bienso")))
                        {
                            giovaolay = rdr.GetString("thoigianvao");
                            String[] thoigianlay = giovaolay.Split(' '); String[] thoigiannhap = giovaonhap.Split(' ');
                            //MessageBox.Show(giovaolay);

                            if ((thoigianlay[0] == thoigiannhap[0]))
                            {

                                // Hiển thị hình ảnh xe vào và xe ra ***************
                                MessageBox.Show("Biến số xe hợp lệ");
                                lbvao.Visible = true; picvao.Visible = true; lbra.Visible = true; picra.Visible = true;
                                rdr.Close();
                                break;
                            }
                            else { MessageBox.Show("Giờ vào không đúng"); rdr.Close(); break; }
                        }
                        
                    }

                }
                else
                {
                    MessageBox.Show("Không có kết nối đến Server !");
                }

            }
            catch (MySqlException)
            {
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Lỗi kết nối đến server !");
                Application.Exit();
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
            this.Hide();
            giaodienchinh to_giaodienchinh = new giaodienchinh();
            to_giaodienchinh.ShowDialog();
            this.Close();

        }
        private void Txtbienso_Enter(object sender, EventArgs e)
        {
            if (txtbienso.Text == "Biển số")

            {
                txtbienso.Text = "";
                txtbienso.ForeColor = Color.Black;
            }
        }

        private void Txtbienso_Leave(object sender, EventArgs e)
        {
            if (txtbienso.Text == "")

            {
                txtbienso.Text = "Biển số";
                txtbienso.ForeColor = Color.Silver;
            }
        }

       
        private void Txtngaygui_Enter(object sender, EventArgs e)
        {
            if (txtngaygui.Text == "Ngày gửi")

            {
                txtngaygui.Text = "";
                txtngaygui.ForeColor = Color.Black;
            }
        }

        private void Txtngaygui_Leave(object sender, EventArgs e)
        {
            if (txtngaygui.Text == "")

            {
                txtngaygui.Text = "Ngày gửi";
                txtngaygui.ForeColor = Color.Black;
            }
        }

        

        private void Thoigianvao_DateChanged(object sender, DateRangeEventArgs e)
        {
            giovaonhap = thoigianvao.SelectionRange.Start.ToString("dd/M/yyyy");
            txtngaygui.Text = giovaonhap;
            //MessageBox.Show(giovaonhap);
        }

        

    }
}
