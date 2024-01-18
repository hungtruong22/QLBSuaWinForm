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
using System.Windows.Forms;

namespace QLBSua
{
    public partial class FormThongKe : Form
    {
        ThongKeBo tkebo = new ThongKeBo();
        TaiKhoanBo tkbo = new TaiKhoanBo();
        HoaDonThanhToanBo hdttbo = new HoaDonThanhToanBo();
        public FormThongKe()
        {
            InitializeComponent();
            lbSLNV.Text = tkbo.TongSLNhanVien().ToString();
            HienThiBanChay();
            HienThiBanCham();
            lbTongSL.Text = hdttbo.TongSoLuongBanDuoc().ToString();
            lbTongDT.Text = hdttbo.TongTienBanDuoc().ToString();
        }
        void HienThiBanChay()
        {
            List<ThongKe> lsbc = tkebo.danhsachbanchay();
            thongKeBindingSource.DataSource = null;
            thongKeBindingSource.DataSource = lsbc;
        }
        void HienThiBanCham()
        {
            List<ThongKe> lsbc = tkebo.danhsachbancham();
            thongKeBindingSource1.DataSource = null;
            thongKeBindingSource1.DataSource = lsbc;
        }
        private void FormThongKe_Load(object sender, EventArgs e)
        {
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormTrangChuAdmin();
            f.ShowDialog();
        }
    }
}
