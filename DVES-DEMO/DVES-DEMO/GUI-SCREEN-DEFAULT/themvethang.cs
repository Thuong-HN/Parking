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
using System.Windows.Forms;

namespace DVES_DEMO
{
    public partial class themvethang : Form
    {
        private int stcomport;
        private string thangdk,namdk, thanghh,namhh, chonxe = "Xe máy";
        MySqlDataReader rdr = null;
        MySqlConnection conn = null;
        public themvethang()
        {
            InitializeComponent();


        }

        private void Themvethang_Load(object sender, EventArgs e)
        {
            try {

                stcomport = giaodienchinh.statuscomport;
            }
            catch { }
        }

        private void Lstchonxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            chonxe = lstchonxe.SelectedItem.ToString();
            MessageBox.Show(chonxe);
        }

        private void Txttien_Enter(object sender, EventArgs e)
        {
            if (txttien.Text == "Nhập số không dấu")
            {
                txttien.Text = "";
                txttien.ForeColor = Color.Black;
            }
        }

        private void Txttien_Leave(object sender, EventArgs e)
        {
            if (txttien.Text == "")
            {
                txttien.Text = "Nhập số không dấu";
                txttien.ForeColor = Color.Silver;
            }
        }

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
            }
            return "NOT";

        }

        

        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            giaodienchinh to_giaodienchinh = new giaodienchinh();
            to_giaodienchinh.ShowDialog();
            this.Close();
        }

        private void Btnxacnhan_Click(object sender, EventArgs e)
        {

            // đọc tagid từ reader
            try
            {
                if (stcomport.Equals(1))
                {

                    DateTime aDateTime = DateTime.Now;
                    //thangdk = aDateTime.ToString("MM");
                    //namdk = aDateTime.ToString("yyyy");

                    //thanghh = Int32.Parse(thangdk);
                    //ngaydangky = aDateTime.ToString();
                    //ngayhethan = ngaydangky;
                    txtngaydangky.Text = aDateTime.ToString("dd/M/yyyy hh:mm tt");
                    //MessageBox.Show(txtngaydangky.Text);
                    txtngayhethan.Text = aDateTime.AddMonths(1).ToString("dd/M/yyyy hh:mm tt");
                    conn = DBUtils.GetDBConnection();
                    conn.Open();

                    if (!txttagid.Text.Equals("") && !txthoten.Text.Equals("") && !txtdiachi.Text.Equals("")
                        && !txtbienso.Text.Equals("") && !txttien.Text.Equals("") && !txtngaydangky.Text.Equals("") && !txtngayhethan.Text.Equals(""))
                    {

                        string[] thang = txtngaydangky.Text.Split('/'); 

                        var comm = conn.CreateCommand();
                        comm.CommandText = "INSERT INTO dvesdkvethang(ten, tagid, bienso, loaixe, ngaydangky, ngayhethan, tien, thang) VALUES(@ten, @id, @bx, @xe, @start, @stop, @tien,@thang)";
                        comm.Parameters.AddWithValue("@ten", txthoten.Text); comm.Parameters.AddWithValue("@id", txttagid.Text);
                        comm.Parameters.AddWithValue("@bx", txtbienso.Text); comm.Parameters.AddWithValue("@xe", chonxe);
                        comm.Parameters.AddWithValue("@start", txtngaydangky.Text); comm.Parameters.AddWithValue("@stop", txtngayhethan.Text);
                        comm.Parameters.AddWithValue("@tien", txttien.Text); comm.Parameters.AddWithValue("@thang", thang[1]);

                        comm.ExecuteNonQuery();
                        DialogResult dialogResult = MessageBox.Show("Đã đồng ý với thông tin người dùng ?", "Đăng ký người dùng mới", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
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
                            this.Hide();
                            giaodienchinh to_giaodienchinh = new giaodienchinh();
                            to_giaodienchinh.ShowDialog();
                            this.Close();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }



                    }
                    else
                    {
                        MessageBox.Show("Đăng ký không thành công, điền đầy đủ thông tin !");
                    }
                }
                else { MessageBox.Show("Vui lòng kết nối đến USB COM"); }


            }
            catch (MySqlException)
            {
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Đăng ký không thành công, lỗi kết nối đến server !");
            }
            
        }

        private void Ngay_hethan(string ngayhethan)
        {
            DateTime aDateTime = DateTime.Now;
            thangdk = aDateTime.ToString("MM");
            namdk = aDateTime.ToString("yyyy");

            //ngayhethan = ngaydangky;

        }
    }
}
