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
using System.Threading;

namespace DVES_DEMO
{
    public partial class doanhthu : Form
    {
        MySqlDataReader rdrthang = null, rdrthuong = null;
        MySqlConnection conn = null;
        private   string[] realthang = new string[12];
        private  string[] realthuong = new string[12];
        private int[] vethang = new int[12];
        private int[] vethuong = new int[12];
        
        Thread newThread_vethuong;
        public doanhthu()
        {
            InitializeComponent();
        }

        private void Doanhthu_Load(object sender, EventArgs e)
        {
            
            conn = DBUtils.GetDBConnection();
            conn.Open();
            newThread_vethuong = new Thread(get_tongtien);
            newThread_vethuong.Start();
            Thread.Sleep(1000);

            

            string[] seriesArray = { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6"
                    , "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"};
            //chart1.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;//x axis
            chart1.ChartAreas[0].AxisX.Title = "Thời gian (tháng)"; chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.Title = "Tiền (VND)"; chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            for (int i = 0; i <12; i++)
            { 
                chart1.Series["VÉ THÁNG"].Points.AddXY(seriesArray[i], vethang[i]);
                chart1.Series["VÉ THƯỜNG"].Points.AddXY(seriesArray[i], vethuong[i]); 
            }
            //AddXY value in chart1 in series named as Salary  
            chart1.Titles.Add("TỔNG DOANH SỐ THU ĐƯỢC ĐẾN THỜI ĐIỂM HIỆN TẠI");
         
            //  *************  LẤY DỮ LIỆU TIỀN  ***************          
        }

        private void get_tongtien()
        {
            try
            {
                //int demthuong=0;
                string prethuong="", prethang = ""; 
                //while (true)
                //{
                    if (conn != null)
                    {
                        //MessageBox.Show("vé thường");
                        string[] thangtmp = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
                      
                        string getvethuongtable = "SELECT thang FROM dvesvetrongngay";

                        MySqlCommand cmdvethuong = new MySqlCommand(getvethuongtable, conn);
                        rdrthuong = cmdvethuong.ExecuteReader();

                        while (rdrthuong.Read())
                        {
                            foreach (string tmp in thangtmp)
                            {
                                //MessageBox.Show(rdrthuong.GetString("thang")+" "+tmp);
                                if (rdrthuong.GetString("thang") == tmp && (rdrthuong.GetString("thang") != prethuong))
                                {
                                    realthuong[Int32.Parse(tmp) -1] = tmp;
                                    //demthuong++;
                                    prethuong = tmp;
                                    //MessageBox.Show("TRÙNG VÉ THƯỜNG----");
                                    break;                              
                                }
                                else {
                                //break;
                                    }
                            }//break;                      
                        }
                        rdrthuong.Close(); //MessageBox.Show("VÉ THƯỜNG"+" "+realthuong[6] +" "+realthuong[7]);
                        for (int k = 0; k < 12; k++)
                        {
                            if (realthuong[k] == null)
                            {
                               
                                realthuong[k] = "0";
                               // MessageBox.Show(k.ToString());
                            }                    
                        }
                   

                    // ********** SUM VÉ THƯỜNG ***************************************************************************************************
                      for (int j =0;j <12; j++)
                      {
                            if (realthuong[j] != "0")
                            {
                            //Console.WriteLine("VÉ THƯỜNG" + " " + realthuong[j]);
                                string resultvethuong = "SELECT sum(tien) FROM dvesvetrongngay WHERE thang = '" + realthuong[j] + "'";
                                MySqlCommand cmdresultvethuong = new MySqlCommand(resultvethuong, conn);

                                vethuong[j] = Int32.Parse(cmdresultvethuong.ExecuteScalar().ToString());
                                }
                            else { vethuong[j] = 0; }
                            //Console.WriteLine(vethuong[j]);

                        }
                       

                    // **************** VÉ THÁNG *************************
                    
                        string getvethangtable = "SELECT thang FROM dvesdkvethang";

                        MySqlCommand cmdvethang = new MySqlCommand(getvethangtable, conn);
                        rdrthang = cmdvethang.ExecuteReader();

                        while (rdrthang.Read())
                        {
                            foreach (string tmp in thangtmp)
                            {
                            //MessageBox.Show(rdrthang.GetString("thang") + " " + tmp);
                                if (rdrthang.GetString("thang") == tmp && (rdrthang.GetString("thang") != prethang))
                                {
                                    realthang[Int32.Parse(tmp) - 1] = tmp;
                                    //demthang++;
                                    prethang = tmp;
                                    //MessageBox.Show("TRÙNG VÉ THÁNG----");
                                    break;
                                }
                                else
                                {
                                //break;
                                }

                            }//break;

                        }
                        rdrthang.Close(); //MessageBox.Show("VÉ THÁNG" + " " + realthang[6]);

                        for (int l = 0; l < 12; l++)
                        {
                            if (realthang[l] == null)
                            {
                                realthang[l] = "0";
                               
                            }
                        }

                        for (int h = 0; h < 12; h++)
                        {
                            if (realthang[h] != "0")
                            {
                                string resultvethang = "SELECT sum(tien) FROM dvesdkvethang WHERE thang = '" + realthang[h] + "'";
                                MySqlCommand cmdresultvethang = new MySqlCommand(resultvethang, conn);

                                vethang[h] = Int32.Parse(cmdresultvethang.ExecuteScalar().ToString());
                               // MessageBox.Show(h.ToString());
                        }
                            else { vethang[h] = 0; }
                        } 
                         
                }
                     
            }
            catch (Exception) {
                MessageBox.Show("ERROR");
                conn.Close();
                conn.Dispose();

                this.Hide();
                giaodienchinh to_giaodienchinh = new giaodienchinh();
                to_giaodienchinh.ShowDialog();
                this.Close();
            }
        }

       
        private void Btnxacnhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            giaodienchinh to_giaodienchinh = new giaodienchinh();
            to_giaodienchinh.ShowDialog();
            this.Close();
        }
    }
}
