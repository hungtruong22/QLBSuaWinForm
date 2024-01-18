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
    public partial class FormLichSu : Form
    {
        HoaDonThanhToanBo hdttbo = new HoaDonThanhToanBo();
        TaiKhoan? TaiKhoan { get; set; }
        public FormLichSu(TaiKhoan tk)
        {
            InitializeComponent();
            this.TaiKhoan = tk;
            if (tk != null)
            {
                lbHoTen.Text = tk.tendn.ToString();
                HienThiLS(tk.matk);
            }
        }

        void HienThiLS(int matk)
        {
            List<HoaDonThanhToan> ls = hdttbo.getSPbyMaTK(matk);
            hoaDonThanhToanBindingSource.DataSource = null;
            hoaDonThanhToanBindingSource.DataSource = ls;
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (FormDangNhap.tk.isAdmin == true)
            {
                this.Hide();
                var f = new FormTrangChuAdmin();
                f.ShowDialog();
            }
            else
            {
                this.Hide();
                var f = new FormTrangChu();
                f.ShowDialog();
            }
        }
    }
}
