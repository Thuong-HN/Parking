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
    public partial class doicongthuc : Form
    {
        MySqlDataReader rdr = null;
        MySqlConnection conn = null;
        public doicongthuc()
        {
            InitializeComponent();
            cbbchongio1.Visible = false; cbbchongio2.Visible = false; lblgia.Visible = false; txtchontien1.Visible = false; txtchontien2.Visible = false;
            cbbchongio3.Visible = false; cbbchongio4.Visible = false; lblchonkhunggio.Visible = false; txtchontien3.Visible = false; txtchontien4.Visible = false;
            txtgiatienngay.Visible = false;lblvnd.Visible = false;
            // lấy trạng thái trên database cập nhật visible cho các item

            
        }

        private void Btntinhtien_ql_Click(object sender, EventArgs e)
        {
            this.Hide();
            quanlyadmin to_quanlyadmin = new quanlyadmin();

            to_quanlyadmin.ShowDialog();
            this.Close();
        }


        private void Cbbchoncachtinhtien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbchoncachtinhtien.SelectedItem == "Theo ngày")
            {
                txtgiatienngay.Visible = true;
                lblvnd.Visible = true;
                cbbchongio1.Visible = false; cbbchongio2.Visible = false; lblgia.Visible = false; txtchontien1.Visible = false; txtchontien2.Visible = false;
                cbbchongio3.Visible = false; cbbchongio4.Visible = false; lblchonkhunggio.Visible = false; txtchontien3.Visible = false; txtchontien4.Visible = false;
                // cần lưu lại chọn lựa trên database

            }
            else if (cbbchoncachtinhtien.SelectedItem == "Theo khung giờ")
            {
                //MessageBox.Show("theo khung gio");
                cbbchongio1.Visible = true; cbbchongio2.Visible = true;lblgia.Visible = true;txtchontien1.Visible = true; txtchontien2.Visible = true;
                cbbchongio3.Visible = true; cbbchongio4.Visible = true;lblchonkhunggio.Visible = true; txtchontien3.Visible = true; txtchontien4.Visible = true;
                txtgiatienngay.Visible = false;lblvnd.Visible = false;
            }
            
        }

        private void Btnxacnhantinhtien_Click(object sender, EventArgs e)
        {
            try
            {
                conn = DBUtils.GetDBConnection();
                conn.Open();
                if (cbbchonloaixe.Text.Equals("Xe máy"))
                {
                   if(cbbchoncachtinhtien.Text.Equals("Theo ngày"))
                    {
                        
                        string updateQuery = "UPDATE dvescongthuctinhtien SET cachtinh = '" + cbbchoncachtinhtien.Text + "', giaguingay = '" + txtgiatienngay.Text +
                            "', khunggio1 = '" + cbbchongio1.Text +
                            "', khunggio2 = '" + cbbchongio2.Text + "', khunggio2 = '" + cbbchongio2.Text + "', khunggio3 = '" + cbbchongio3.Text + "', khunggio4 = '" + cbbchongio4.Text +
                            "', gia1 = '" + txtchontien1.Text + "', gia2 = '" + txtchontien2.Text + "', gia3 = '" + txtchontien3.Text + "', gia4 = '" + txtchontien4.Text + "' WHERE id='0'";
                        MySqlCommand cm1 = new MySqlCommand(updateQuery, conn);
                        cm1.CommandText = updateQuery;
                        cm1.Connection = conn;
                        cm1.ExecuteNonQuery();
                        
                        
                    }
                   else
                    {
                        string updateQuery = "UPDATE dvescongthuctinhtien SET cachtinh = '" + cbbchoncachtinhtien.Text + "', khunggio1 = '" + cbbchongio1.Text +
                            "', khunggio2 = '" + cbbchongio2.Text + "', khunggio2 = '" + cbbchongio2.Text + "', khunggio3 = '" + cbbchongio3.Text + "', khunggio4 = '" + cbbchongio4.Text +
                            "', gia1 = '" + txtchontien1.Text + "', gia2 = '" + txtchontien2.Text + "', gia3 = '" + txtchontien3.Text + "', gia4 = '" + txtchontien4.Text + "', giaguingay = '" + txtgiatienngay.Text + "' WHERE id='0'";
                        MySqlCommand cm1 = new MySqlCommand(updateQuery, conn);
                        cm1.CommandText = updateQuery;
                        cm1.Connection = conn;
                        cm1.ExecuteNonQuery();
                    }
                    cbbchoncachtinhtien.Text = "";cbbchongio1.Text = ""; cbbchongio2.Text = ""; cbbchongio3.Text = ""; cbbchongio4.Text = "";
                    txtchontien1.Text = ""; txtchontien2.Text = ""; txtchontien3.Text = ""; txtchontien4.Text = "";cbbchonloaixe.Text = "";
                    txtgiatienngay.Text = "";
                    MessageBox.Show("Đã lưu cách tính tiền cho xe máy");

                }
                else if (cbbchonloaixe.Text.Equals("Xe ô tô"))
                {
                    if (cbbchoncachtinhtien.Text.Equals("Theo ngày"))
                    {

                        string updateQuery = "UPDATE dvescongthuctinhtien SET cachtinh = '" + cbbchoncachtinhtien.Text + "', giaguingay = '" + txtgiatienngay.Text +
                            "', khunggio1 = '" + cbbchongio1.Text +
                            "', khunggio2 = '" + cbbchongio2.Text + "', khunggio2 = '" + cbbchongio2.Text + "', khunggio3 = '" + cbbchongio3.Text + "', khunggio4 = '" + cbbchongio4.Text +
                            "', gia1 = '" + txtchontien1.Text + "', gia2 = '" + txtchontien2.Text + "', gia3 = '" + txtchontien3.Text + "', gia4 = '" + txtchontien4.Text + "' WHERE id='1'";
                        MySqlCommand cm1 = new MySqlCommand(updateQuery, conn);
                        cm1.CommandText = updateQuery;
                        cm1.Connection = conn;
                        cm1.ExecuteNonQuery();
                        
                    }
                    else
                    {
                        string updateQuery = "UPDATE dvescongthuctinhtien SET cachtinh = '" + cbbchoncachtinhtien.Text + "', khunggio1 = '" + cbbchongio1.Text +
                            "', khunggio2 = '" + cbbchongio2.Text + "', khunggio2 = '" + cbbchongio2.Text + "', khunggio3 = '" + cbbchongio3.Text + "', khunggio4 = '" + cbbchongio4.Text +
                            "', gia1 = '" + txtchontien1.Text + "', gia2 = '" + txtchontien2.Text + "', gia3 = '" + txtchontien3.Text + "', gia4 = '" + txtchontien4.Text + "', giaguingay = '" + txtgiatienngay.Text + "' WHERE id='1'";
                        MySqlCommand cm1 = new MySqlCommand(updateQuery, conn);
                        cm1.CommandText = updateQuery;
                        cm1.Connection = conn;
                        cm1.ExecuteNonQuery();
                    }
                    txtgiatienngay.Text = "";
                    cbbchoncachtinhtien.Text = ""; cbbchongio1.Text = ""; cbbchongio2.Text = ""; cbbchongio3.Text = ""; cbbchongio4.Text = "";
                    txtchontien1.Text = ""; txtchontien2.Text = ""; txtchontien3.Text = ""; txtchontien4.Text = ""; cbbchonloaixe.Text = "";
                    MessageBox.Show("Đã lưu cách tính tiền cho xe ô tô");
                }
                else if (cbbchonloaixe.Text.Equals("Xe đạp"))
                {
                    if (cbbchoncachtinhtien.Text.Equals("Theo ngày"))
                    {

                        string updateQuery = "UPDATE dvescongthuctinhtien SET cachtinh = '" + cbbchoncachtinhtien.Text + "', giaguingay = '" + txtgiatienngay.Text +
                            "', khunggio1 = '" + cbbchongio1.Text +
                            "', khunggio2 = '" + cbbchongio2.Text + "', khunggio2 = '" + cbbchongio2.Text + "', khunggio3 = '" + cbbchongio3.Text + "', khunggio4 = '" + cbbchongio4.Text +
                            "', gia1 = '" + txtchontien1.Text + "', gia2 = '" + txtchontien2.Text + "', gia3 = '" + txtchontien3.Text + "', gia4 = '" + txtchontien4.Text + "' WHERE id='2'";
                        MySqlCommand cm1 = new MySqlCommand(updateQuery, conn);
                        cm1.CommandText = updateQuery;
                        cm1.Connection = conn;
                        cm1.ExecuteNonQuery();
                        
                    }
                    else
                    {
                        string updateQuery = "UPDATE dvescongthuctinhtien SET cachtinh = '" + cbbchoncachtinhtien.Text + "', khunggio1 = '" + cbbchongio1.Text +
                            "', khunggio2 = '" + cbbchongio2.Text + "', khunggio2 = '" + cbbchongio2.Text + "', khunggio3 = '" + cbbchongio3.Text + "', khunggio4 = '" + cbbchongio4.Text +
                            "', gia1 = '" + txtchontien1.Text + "', gia2 = '" + txtchontien2.Text + "', gia3 = '" + txtchontien3.Text + "', gia4 = '" + txtchontien4.Text + "', giaguingay = '" + txtgiatienngay.Text + "' WHERE id='2'";
                        MySqlCommand cm1 = new MySqlCommand(updateQuery, conn);
                        cm1.CommandText = updateQuery;
                        cm1.Connection = conn;
                        cm1.ExecuteNonQuery();
                    }
                    txtgiatienngay.Text = "";
                    cbbchoncachtinhtien.Text = ""; cbbchongio1.Text = ""; cbbchongio2.Text = ""; cbbchongio3.Text = ""; cbbchongio4.Text = "";
                    txtchontien1.Text = ""; txtchontien2.Text = ""; txtchontien3.Text = ""; txtchontien4.Text = ""; cbbchonloaixe.Text = "";
                    MessageBox.Show("Đã lưu cách tính tiền cho xe đạp");
                }

                conn.Close();
                conn.Dispose();
                //MessageBox.Show("theo ngay");



            }
            catch (Exception) {
                conn.Close();
                conn.Dispose();
            }

        }
    }
}
