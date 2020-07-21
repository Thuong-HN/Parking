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
using MySql.Data.MySqlClient;

namespace DVES_DEMO
{
    public partial class thongke : Form
    {
        MySqlDataReader rdrthang = null, rdrthuong = null;
        MySqlConnection conn = null;
        private int[] slthang = new int[12];
        private int[] slthuong = new int[12];
        
        private int[] demthuong = new int[12];
        private int[] demthang = new int[12];
        Thread newThread_vethuong;

        public thongke()
        {
            InitializeComponent();
        }

     

        private void Thongke_Load(object sender, EventArgs e)
        {
            conn = DBUtils.GetDBConnection();
            conn.Open();
            newThread_vethuong = new Thread(get_tongxe);
            newThread_vethuong.Start();
            Thread.Sleep(1000);



            string[] seriesArray = { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6"
                    , "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"};
            //chart1.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;//x axis
            chart1.ChartAreas[0].AxisX.Title = "Thời gian (tháng)"; chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.Title = "Số lượng xe (chiếc)"; chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            for (int i = 0; i < 12; i++)
            {
                chart1.Series["VÉ THÁNG"].Points.AddXY(seriesArray[i], demthang[i]);
                chart1.Series["VÉ THƯỜNG"].Points.AddXY(seriesArray[i], demthuong[i]);
            }
            //AddXY value in chart1 in series named as Salary  
            chart1.Titles.Add("TỔNG DOANH SỐ THU ĐƯỢC ĐẾN THỜI ĐIỂM HIỆN TẠI");

        }

        

        private void get_tongxe()
        {
            try
            { 
                string prethuong = "", prethang = "";         
                if (conn != null)
                {
                    //MessageBox.Show("vé thường");
                    string[] thangtmp = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

                    string getvethuongtable = "SELECT thang FROM dvesvetrongngay";

                    MySqlCommand cmdvethuong = new MySqlCommand(getvethuongtable, conn);
                    rdrthuong = cmdvethuong.ExecuteReader();

                    while (rdrthuong.Read())
                    {
                        foreach (string tmp in thangtmp)
                        {
                            if (rdrthuong.GetString("thang") == tmp)
                            {
                                
                                switch (rdrthuong.GetString("thang"))
                                {
                                    case "1":

                                        demthuong[0]++;

                                        break;
                                    case "2":
                                        demthuong[1]++;
                                        break;
                                    case "3":
                                        demthuong[2]++;
                                        break;
                                    case "4":
                                        demthuong[3]++;
                                        break;
                                    case "5":
                                        demthuong[4]++;
                                        break;
                                    case "6":
                                        demthuong[5]++;
                                        break;
                                    case "7":
                                        demthuong[6]++;
                                        
                                        break;
                                    case "8":
                                        demthuong[7]++;
                                        
                                        break;
                                    case "9":
                                        demthuong[8]++;
                                        break;
                                    case "10":
                                        demthuong[9]++;
                                        break;
                                    case "11":
                                        demthuong[10]++;
                                        break;
                                    case "12":
                                        demthuong[11]++;
                                        break;
                                    default:
                                       
                                        break;
                                }
                            }
                            
                            //MessageBox.Show(rdrthuong.GetString("thang")+" "+tmp);
                          /*  if (rdrthuong.GetString("thang") == tmp)
                            {
                                slthuong[Int32.Parse(tmp) - 1] = demthuong;
                                demthuong++;
                                
                                //MessageBox.Show("TRÙNG VÉ THƯỜNG----");
                                //break;
                            }
                            */
                        }//break;         
                        //demthuong = 1;
                    }
                    rdrthuong.Close(); //MessageBox.Show("VÉ THƯỜNG"+" "+realthuong[6] +" "+realthuong[7]);
                    
                    // **************** VÉ THÁNG *************************

                    string getvethangtable = "SELECT thang FROM dvesdkvethang";

                    MySqlCommand cmdvethang = new MySqlCommand(getvethangtable, conn);
                    rdrthang = cmdvethang.ExecuteReader();

                    while (rdrthang.Read())
                    {
                        foreach (string tmp in thangtmp)
                        {
                            if (rdrthang.GetString("thang") == tmp)
                            {
                                switch (rdrthang.GetString("thang"))
                                {
                                    case "1":

                                        demthang[0]++;

                                        break;
                                    case "2":
                                        demthang[1]++;
                                        break;
                                    case "3":
                                        demthang[2]++;
                                        break;
                                    case "4":
                                        demthang[3]++;
                                        break;
                                    case "5":
                                        demthang[4]++;
                                        break;
                                    case "6":
                                        demthang[5]++;
                                        break;
                                    case "7":
                                        demthang[6]++;

                                        break;
                                    case "8":
                                        demthang[7]++;

                                        break;
                                    case "9":
                                        demthang[8]++;
                                        break;
                                    case "10":
                                        demthang[9]++;
                                        break;
                                    case "11":
                                        demthang[10]++;
                                        break;
                                    case "12":
                                        demthang[11]++;
                                        break;
                                    default:

                                        break;
                                }
                            }
                            
                            /*
                            //MessageBox.Show(rdrthang.GetString("thang") + " " + tmp);
                            if (rdrthang.GetString("thang") == tmp )
                            {
                                slthang[Int32.Parse(tmp) - 1] = demthang;
                                demthang++;
                              
                                //MessageBox.Show("TRÙNG VÉ THÁNG----");
                                //break;
                            } */
                            
                        }//break;
                        //demthang=1;

                    }
                    rdrthang.Close(); //MessageBox.Show("VÉ THÁNG" + " " + realthang[6]);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
                conn.Close();
                conn.Dispose();
                this.Hide();
                giaodienchinh to_giaodienchinh = new giaodienchinh();
                to_giaodienchinh.ShowDialog();
                this.Close();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            giaodienchinh to_giaodienchinh = new giaodienchinh();
            to_giaodienchinh.ShowDialog();
            this.Close();
        }
    }
}
