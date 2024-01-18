using QLBSua.Bo;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace QLBSua
{
    public partial class FormQuanLyHoaDon : Form
    {
        HoaDonBo hdbo = new HoaDonBo();
        HoaDonThanhToanBo hdttbo = new HoaDonThanhToanBo();
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            lbTongHD.Text = hdbo.TongHD().ToString();
            HienThiHD();
        }

        void HienThiHD()
        {
            List<HoaDon> ls = hdbo.getHD();
            hoaDonBindingSource.DataSource = null;
            hoaDonBindingSource.DataSource = ls;
        }
        void HienThiChiTiet(HoaDon hd)
        {
            List<HoaDonThanhToan> ls = hdttbo.getSPbyMaHD(hd.mahd);
            hoaDonThanhToanBindingSource.DataSource = null;
            hoaDonThanhToanBindingSource.DataSource = ls;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormTrangChuAdmin();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDon hd = hoaDonBindingSource.Current as HoaDon;
            HienThiChiTiet(hd);
        }
    }
}
