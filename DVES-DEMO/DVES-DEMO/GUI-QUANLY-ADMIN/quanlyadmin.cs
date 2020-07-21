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
    public partial class quanlyadmin : Form
    {
        public quanlyadmin() => InitializeComponent();

        private void Btndoitk_Click(object sender, EventArgs e)
        {
            this.Hide();
            doitaikhoan to_doitk = new doitaikhoan();
            to_doitk.ShowDialog();
            this.Close();
        }

        private void Btnchondg_Click(object sender, EventArgs e)
        {
            this.Hide();
            caidatgiaodien to_caidatgiaodien = new caidatgiaodien();
            to_caidatgiaodien.ShowDialog();
            this.Close();
        }

        private void Btnxoadl_Click(object sender, EventArgs e)
        {
            this.Hide();
            xoadulieu to_xoadulieu = new xoadulieu();
            to_xoadulieu.ShowDialog();
            this.Close();
        }

        private void Btndoict_Click(object sender, EventArgs e)
        {
            this.Hide();
            doicongthuc to_doicongthuc = new doicongthuc();
            to_doicongthuc.ShowDialog();
            this.Close();
        }

        private void Btnquanlyadmin_ql_Click(object sender, EventArgs e)
        {
            this.Hide();
            giaodienchinh to_giaodienchinh = new giaodienchinh();

            to_giaodienchinh.ShowDialog();
            this.Close();
        }
    }
}
