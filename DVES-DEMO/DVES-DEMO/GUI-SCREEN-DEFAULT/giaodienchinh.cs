using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DVES_DEMO
{
    public partial class giaodienchinh : Form
    {
        public static int statuscomport, sttsaive;
        private int checkvethang_in, flag_in, sttbutton_in, checkvethang_out, flag_out, sttbutton_out, checkxemay, checkoto, checkxedap;
        private string tiengui;
        MySqlDataReader rdr = null;
        MySqlConnection conn = null;
        Thread newThread_IN;
        public giaodienchinh()
        {
            InitializeComponent();
            // đọc tagid từ reader
            
        }

        private void Giaodienchinh_Load(object sender, EventArgs e)
        {
            lbtimeinhethan.Visible = false; txttimeinhethan.Visible = false; lbtimeouthethan.Visible = false; txttimeouthethan.Visible = false;
            chkxemay.Checked = true;
            //*********************************************************************************************
            String comportname = GetComPort("USB\\VID_1A86&PID_7523");
           
            if (!comportname.Equals("NOT"))
            {

                SerialPort comport = new SerialPort(comportname, 9600, Parity.None, 8, StopBits.One);

                comport.Open();
                comport.DtrEnable = true;
                comport.RtsEnable = true;
                if (comport.IsOpen)
                {
                    picketnoimudule.BackColor = Color.Lime;
                    statuscomport = 1; // lưu lại trạng thái kết nối USB cho các thao tác sau
                                       
                }
                else
                {
                    picketnoimudule.BackColor = Color.Red;
                    statuscomport = 0;
                }


            }
            else
            {
                MessageBox.Show("Kết nối không thành công"); 
            }

            //*********************************************************************************************
           
            // Kết nối đến Database **************************
            // Tiến hành đọc thẻ quét cho xe VÀO********************************************

            newThread_IN = new Thread(IN_read_tagid);
            newThread_IN.Start();

        }



        // *****************  HÀM XỬ LÝ KHI CÓ THẺ QUẸT VÀO/RA  *************************************
        private void IN_read_tagid()
        {
            try
            {
                conn = DBUtils.GetDBConnection();
                conn.Open();
                //MessageBox.Show("LOOP");
                
                while (statuscomport == 1)
                
                {
                
                    MethodInvoker mi = delegate () {

                        // ************ XỬ LÝ XE VÀO ******************
                        if (sttbutton_in == 1)   // CÓ THẺ QUẸT
                        {
                            checkvethang_in = 0; flag_in = 0;
                            if (txtmathevao.Text != "" && txtbiensovao.Text != "")
                            {
                                // MessageBox.Show("thread");
                                DateTime aDateTime = DateTime.Now;
                                if (conn != null)
                                {
                                    string getdata = "SELECT * FROM dvesdkvethang";
                                    MySqlCommand cmdzs = new MySqlCommand(getdata, conn);
                                    rdr = cmdzs.ExecuteReader();
                                    while (rdr.Read())
                                    {
                                        if (txtmathevao.Text.Equals(rdr.GetString("tagid")))
                                        {
                                            MessageBox.Show("trùng vé tháng");
                                            //mathe.Text = ""; bienso.Text = "";
                                            lbtimeinhethan.Visible = true; txttimeinhethan.Visible = true;
                                            //bienso.Text = rdr.GetString("bienso");
                                            txttimevao.Text = aDateTime.ToString("dd/M/yyyy hh:mm tt");
                                            lbloaivevao.Text = "Vé tháng";
                                            txttimeinhethan.Text = rdr.GetString("ngayhethan");
                                            checkvethang_in = 1;
                                            rdr.Close();
                                            break;
                                        }
                                        //else { rdr.Close(); break; } //**** PHẢI CLOSE command đã gọi trước đó để khi khởi tạo các command sau không bị chồng

                                    }rdr.Close();



                                    if (checkvethang_in != 1 && flag_in == 0) // ** KHI MÃ THẺ KHÔNG PHẢI VÉ THÁNG **
                                    {
                                        lbtimeinhethan.Visible = false; txttimeinhethan.Visible = false;
                                        flag_in = 1;
                                        txttimevao.Text = aDateTime.ToString("dd/M/yyyy hh:mm tt");
                                        string[] thang = txttimevao.Text.Split('/');
                                        var insertvethuong = conn.CreateCommand();
                                        insertvethuong.CommandText = "INSERT INTO dvesvetrongngay (tagid, bienso, loaixe,loaive, thoigianvao,hinhanhvao,thang) VALUES (@id, @bx, @xe,@ve, @start, @imgvao,@thang)";
                                        //insertvethuong.CommandText = "insert into dvesvetrongngay (tagid,bienso,loaixe,loaive,thoigianvao,hinhanhvao,thoigianra,hinhanhra,tien) values('" + mathe.Text + "','" + mathe.Text + "','" + mathe.Text + "','" + mathe.Text + "','" + mathe.Text + "','" + mathe.Text + "','" + mathe.Text + "','" + mathe.Text + "','" + mathe.Text + "');";
                                        insertvethuong.Parameters.AddWithValue("@id", txtmathevao.Text);
                                        insertvethuong.Parameters.AddWithValue("@bx", txtbiensovao.Text);
                                        insertvethuong.Parameters.AddWithValue("@xe", "xe máy");
                                        insertvethuong.Parameters.AddWithValue("@ve", "vé thường");
                                        insertvethuong.Parameters.AddWithValue("@start", txttimevao.Text);
                                        insertvethuong.Parameters.AddWithValue("@imgvao", "link ảnh vào");
                                        insertvethuong.Parameters.AddWithValue("@thang", thang[1]);

                                        insertvethuong.ExecuteNonQuery();
                                        MessageBox.Show("Vé thường ----");

                                    }
                                    

                                }
                                else
                                {
                                    MessageBox.Show("Không có kết nối đến Server, đang kết nối lại ...");
                                    conn = DBUtils.GetDBConnection();
                                    conn.Open();
                                }

                            }
                            sttbutton_in = 0;
                            Thread.Sleep(1000);
                            txtmathevao.Text = ""; txtbiensovao.Text = ""; txttimevao.Text = "";
                        }
                        


                        //  *********************   XỬ LÝ XE RA   ************************************

                        if (sttbutton_out == 1)
                        {
                            checkvethang_out = 0; flag_out = 0;
                            if (txtmathera.Text != "" && txtbiensora.Text != "")
                            {
                                // MessageBox.Show("thread");
                                DateTime aDateTime = DateTime.Now;
                                if (conn != null)
                                {
                                    //************************************************************
                                    string getdata = "SELECT * FROM dvesdkvethang";
                                    MySqlCommand cmdzs = new MySqlCommand(getdata, conn);
                                    rdr = cmdzs.ExecuteReader();
                                    while (rdr.Read())
                                    {
                                        if (txtmathera.Text == (rdr.GetString("tagid")))
                                        {
                                            MessageBox.Show("VÉ THÁNG");
                                            
                                            lbtimeouthethan.Visible = true; txttimeouthethan.Visible = true;
                                           
                                            txttimera.Text = aDateTime.ToString("dd/M/yyyy hh:mm tt");
                                            lbloaivera.Text = "Vé tháng";
                                            txttimeouthethan.Text = rdr.GetString("ngayhethan");

                                            checkvethang_out = 1;
                                           
                                            

                                            rdr.Close();
                                            break;
                                        }
                                        //else { rdr.Close(); break; } //**** PHẢI CLOSE command đã gọi trước đó để khi khởi tạo các command sau không bị chồng

                                    }rdr.Close();
                                    


                                    if (checkvethang_out != 1 && flag_out == 0) // ** KHI MÃ THẺ KHÔNG PHẢI VÉ THÁNG **
                                    {
                                        lbtimeouthethan.Visible = false; txttimeouthethan.Visible = false;
                                        // **************************  TÍNH TIỀN CHO VÉ THƯỜNG THEO TỪNG LOẠI XE VÀ THEO CÔNG THỨC TÍNH TIỀN ******************************
                                        //                            TÍNH THEO NGÀY  VÀ TÍNH THEO KHUNG GIỜ
                                        string gettien = "SELECT * FROM dvescongthuctinhtien";
                                        MySqlCommand cmdtien = new MySqlCommand(gettien, conn);
                                        rdr = cmdtien.ExecuteReader();
                                        while (rdr.Read())
                                        {
                                            MessageBox.Show("TÍNH TIỀN XE" + " " + checkoto + " " + rdr.GetString("loai xe"));
                                            if ((checkxemay == 1) && (rdr.GetString("loai xe") == "Xe máy")) // TÍNH THEO NGÀY 
                                            {

                                                tiengui = rdr.GetString("giaguingay");
                                                //MessageBox.Show("XE MÁY --------");
                                                rdr.Close();
                                                break;
                                            }
                                            else if ((checkoto == 1) && (rdr.GetString("loai xe") == "Xe ô tô")) // TÍNH THEO NGÀY 
                                            {

                                                tiengui = rdr.GetString("giaguingay");
                                                //MessageBox.Show("XE Ô TÔ --------");
                                                rdr.Close();
                                                break;
                                            }
                                            else if ((checkxedap == 1) && (rdr.GetString("loai xe") == "Xe đạp")) // TÍNH THEO NGÀY 
                                            {

                                                tiengui = rdr.GetString("giaguingay");
                                                //MessageBox.Show("XE ĐẠP --------");
                                                rdr.Close();
                                                break;
                                            }
                                            //else { rdr.Close(); break; } //**** PHẢI CLOSE command đã gọi trước đó để khi khởi tạo các command sau không bị chồng

                                        }
                                        rdr.Close();

                                        // *********************************************************

                                        // *** KIỂM TRA DATABASE VÉ THƯỜNG *****
                                        string getvethuong = "SELECT * FROM dvesvetrongngay";
                                        MySqlCommand cmdvethuong = new MySqlCommand(getvethuong, conn);
                                        rdr = cmdvethuong.ExecuteReader();
                                        while (rdr.Read())
                                        {
                                            if (txtmathera.Text == (rdr.GetString("tagid")))
                                            {

                                                flag_out = 1;sttsaive = 1;
                                                txttimera.Text = aDateTime.ToString("dd/M/yyyy hh:mm tt");
                                                lbloaivera.Text = "Vé thường";
                                                txttienra.Text = tiengui;

                                                MessageBox.Show("VÉ THƯỜNG");
                                                rdr.Close();
                                                break;
                                            }
                                            //else { sttsaive = 1; } //**** PHẢI CLOSE command đã gọi trước đó để khi khởi tạo các command sau không bị chồng

                                        }rdr.Close();

                                        if (flag_out == 1)
                                        {
                                            flag_out = 0;
                                            string updateQuery = "UPDATE dvesvetrongngay SET thoigianra = '" + txttimera.Text + "', hinhanhra = 'link ảnh ra', tien = '" + tiengui + "' WHERE tagid = '" + txtmathera.Text + "' ";
                                            MySqlCommand cmdupdate = new MySqlCommand(updateQuery, conn);
                                            cmdupdate.CommandText = updateQuery;
                                            cmdupdate.Connection = conn;
                                            cmdupdate.ExecuteNonQuery();
                                        }
                                        if (sttsaive != 1)
                                        {
                                            flag_out = 0;
                                            MessageBox.Show("SAI VÉ!");
                                            //sttsaive = 0;
                                        }
                                       
                                    }
                                    

                                }
                                else
                                {
                                    MessageBox.Show("Không có kết nối đến Server, đang kết nối lại ...");
                                    conn = DBUtils.GetDBConnection();
                                    conn.Open();
                                }

                            }
                            sttbutton_out = 0;
                            Thread.Sleep(1000);
                            txtmathevao.Text = ""; txtbiensovao.Text = ""; txttimevao.Text = ""; txttienra.Text = "";
                        }
                        

                    }; this.Invoke(mi);


                }
                Thread.Sleep(2000);
                conn.Close();
                conn.Dispose();
                 
            }
            catch (Exception)
            {
                
                conn.Close();
                conn.Dispose();
                //Application.Exit();
            }

        }

        // ************  XỬ LÝ HÌNH ẢNH/VIDEO TỪ MUDULE CAMERA  *****************************
        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            // axWindowsMediaPlayer1.URL = @"D:\THUONG\English\ＣＨＩＬＬＯＵＴ.mp4";
        }

        private void AxWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer2.URL = @"D:\THUONG\English\ＣＨＩＬＬＯＵＴ.mp4";
        }


        //*********************************** NÚT SỰ KIỆN TRONG FORM ***********************************************
        private void ĐăngNhậpVàoAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhapADM to_dangnhapadm = new dangnhapADM();
            to_dangnhapadm.ShowDialog();
            this.Close();
        }

        private void Picthemvethang_Click(object sender, EventArgs e)
        {

            this.Hide();
            themvethang to_themvethang = new themvethang();
            to_themvethang.ShowDialog();
            this.Close();
        }

        private void Stripthemvethang_Click(object sender, EventArgs e)
        {
            this.Hide();
            themvethang to_themvethang = new themvethang();
            to_themvethang.ShowDialog();
            this.Close();
        }

        private void Striptinhtrangve_Click(object sender, EventArgs e)
        {
            this.Hide();
            tinhtrangve to_tinhtrangve = new tinhtrangve();
            to_tinhtrangve.ShowDialog();
            this.Close();
        }

        private void Stripgiahanve_Click(object sender, EventArgs e)
        {
            this.Hide();
            giahanvethang to_giahanve = new giahanvethang();
            to_giahanve.ShowDialog();
            this.Close();
        }

        private void Chkxeoto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkxeoto.Checked)
            {
                //MessageBox.Show(" CHECK xe ô tô");
                checkoto = 1;
                checkxemay = 0; checkxedap = 0; chkxedap.Checked = false; chkxemay.Checked = false;
            }
            else
            {

            }
            
        }

        private void Picdoanhthu_Click(object sender, EventArgs e)
        {
            this.Hide();
            doanhthu to_doanhthu = new doanhthu();
            to_doanhthu.ShowDialog();
            this.Close();
        }

        private void Picthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            thongke to_thongke = new thongke();
            to_thongke.ShowDialog();
            this.Close();
        }

        private void Chkxedap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkxedap.Checked)
            {
                //MessageBox.Show(" CHECK xe đạp");
                checkoto = 0;
                checkxemay = 0; checkxedap = 1; chkxeoto.Checked = false; chkxemay.Checked = false;
            }
            else
            {

            }
            
        }
        private void Chkxemay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkxemay.Checked)
            {
                //MessageBox.Show(" CHECK xe máy");
                checkoto = 0;
                checkxemay = 1; checkxedap = 0; chkxedap.Checked = false; chkxeoto.Checked = false;
            }
            else
            {

            }
           
        }
      
        private void Stripmatve_Click(object sender, EventArgs e)
        {
            this.Hide();
            matve to_matve = new matve();
            to_matve.ShowDialog();
            this.Close();
        }

       

        private void HủyVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            huyve to_huyve = new huyve();
            to_huyve.ShowDialog();
            this.Close();
        }

        private void Pictimkiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            truyxuat to_truyxuat = new truyxuat();
            to_truyxuat.ShowDialog();
            this.Close();
        }
        //********************************************************************************************


        // hàm giao tiếp với usb
        public string GetComPort(string hardwareId)
        {

            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");

                foreach (ManagementObject port in searcher.Get())
                {
                    string name = port["Name"].ToString();
                    if (name.Contains("COM"))
                    {
                        string[] o = (string[])port["HardwareId"];
                        if (o != null)
                        {
                            if (o.Length > 1)
                            {
                                string[] Sp = SerialPort.GetPortNames();
                                if (o[1] == hardwareId)
                                {
                                    foreach (string PortName in Sp)
                                    {
                                        if (name.Contains(PortName)) return PortName;
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (ManagementException)
            {
                MessageBox.Show("không có kết nối USB");
            }
            return "NOT";

        }

        // ****** NHẤN NÚT VÀO/RA
        private void Btnvao_Click(object sender, EventArgs e)
        {
            sttbutton_in = 1;
        }
        private void Btnra_Click(object sender, EventArgs e)
        {
            sttbutton_out = 1;
        }
        
        // **** ĐÓNG ỨNG DỤNG *********
        private void Giaodienchinh_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("BẠN CÓ MUỐN TẮT PHẦN MỀM?", "ĐÓNG ỨNG DỤNG", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                newThread_IN.Abort();
                Application.ExitThread();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
            
        }


    } 
}
