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
    public partial class FormHoaDon : Form
    {
        HoaDonThanhToanBo hdttbo = new HoaDonThanhToanBo();
        public TaiKhoan? TaiKhoan { get; set; }
        public DateTime? nm { get; set; }
        public long? mhd { get; set; }
        public FormHoaDon(TaiKhoan tk, DateTime ngaymua, long mahd, int slm, double tongthanhtoan)
        {
            this.TaiKhoan = tk;
            this.nm = ngaymua;
            this.mhd = mahd;
            if (tk != null && ngaymua != null && slm != null && tongthanhtoan != null && mahd != null)
            {

                InitializeComponent();
                lbHoTen.Text = FormDangNhap.tk.tendn.ToString();
                lbNgayMua.Text = ngaymua.ToString();
                HienThiHD(mahd);
                lbTSL.Text = slm.ToString();
                lbTTT.Text = tongthanhtoan.ToString();
            }


        }
        void HienThiHD(long mahd)
        {
            List<HoaDonThanhToan> ls = hdttbo.getSPbyMaHD(mahd);
            hoaDonThanhToanBindingSource.DataSource = null;
            hoaDonThanhToanBindingSource.DataSource = ls;
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
