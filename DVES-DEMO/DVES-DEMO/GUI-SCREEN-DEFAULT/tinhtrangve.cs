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
    public partial class tinhtrangve : Form
    {
       
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;
        public tinhtrangve()
        {
            InitializeComponent();
            
        }
        
        private void Tinhtrangve_Load(object sender, EventArgs e)
        {
            
            try
            {

                conn = DBUtils.GetDBConnection();
                conn.Open();

                if (conn != null)
                {

                    string getdata = "SELECT ten FROM dvesdkvethang";
                    MySqlCommand cmdzs = new MySqlCommand(getdata, conn);
                    rdr = cmdzs.ExecuteReader();
                    while (rdr.Read())
                    {
                        lstten.Items.Add(rdr.GetString("ten"));

                    }

                }
                else
                {
                    MessageBox.Show("Không có kết nối đến Server !");
                }
                
            }
            catch (MySqlException )
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
            this.Hide();
            giaodienchinh to_giaodienchinh = new giaodienchinh();
            to_giaodienchinh.ShowDialog();
            this.Close();
            /*
            try
            {
                
                conn = DBUtils.GetDBConnection();
                conn.Open();

                if (conn != null && txtten.Text != null)
                {

                    string getdata = "SELECT * FROM dvesdkvethang";
                    MySqlCommand cmdzs = new MySqlCommand(getdata, conn);
                    rdr = cmdzs.ExecuteReader();
                    while (rdr.Read())
                    { 
                        lstten.Items.Add(rdr.GetString("ten"));
                        if (txtten.Text == (rdr.GetString("ten")))
                        {
                            txttagid.Text = rdr.GetString("tagid");
                            txtbienso.Text = rdr.GetString("bienso");
                            txtloaixe.Text = rdr.GetString("loaixe");
                            txtngaybatdau.Text = rdr.GetString("ngaydangky");
                            txtngayhenhan.Text = rdr.GetString("ngayhethan");
                            txttien.Text = rdr.GetString("tien");
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
            //this.Hide();
            //giaodienchinh to_giaodienchinh = new giaodienchinh();
            //to_giaodienchinh.ShowDialog();
            //this.Close();
            */
        }

        private void Lstten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstten.SelectedItem != null)
            {
                try
                {

                    conn = DBUtils.GetDBConnection();
                    conn.Open();

                    if (conn != null )
                    {

                        string getdata = "SELECT * FROM dvesdkvethang";
                        MySqlCommand cmdzs = new MySqlCommand(getdata, conn);
                        rdr = cmdzs.ExecuteReader();
                        while (rdr.Read())
                        {
                           
                            if (lstten.SelectedItem.Equals(rdr.GetString("ten")))
                            {
                                txtten.Text = rdr.GetString("ten");
                                txttagid.Text = rdr.GetString("tagid");
                                txtbienso.Text = rdr.GetString("bienso");
                                txtloaixe.Text = rdr.GetString("loaixe");
                                txtngaybatdau.Text = rdr.GetString("ngaydangky");
                                txtngayhenhan.Text = rdr.GetString("ngayhethan");
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
}
