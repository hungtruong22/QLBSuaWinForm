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
    public partial class FormThongTinCaNhan : Form
    {
        TaiKhoanBo tkbo = new TaiKhoanBo();
        TaiKhoan? taiKhoan { get; set; }
        public FormThongTinCaNhan(TaiKhoan tk)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            if (tk != null)
            {
                HienThiThongTinCaNhan(tk);
            }
        }

        void HienThiThongTinCaNhan(TaiKhoan tk)
        {
            txtMaTK.Text = tk.matk.ToString();
            txtTenDN.Text = tk.tendn;
            txtEmail.Text = tk.email;
            if (tk.isAdmin == true)
            {
                txtChucVu.Text = "Admin";
            }
            else
            {
                txtChucVu.Text = "Nhân Viên";
            }
            txtTrangThai.Text = "Đang hoạt động";
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (taiKhoan.isAdmin == true)
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

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormDoiMatKhau(FormDangNhap.tk);
            f.ShowDialog();
        }

        private void btnChinhSuaTT_Click(object sender, EventArgs e)
        {
            string matk = txtMaTK.Text;
            string tendn = txtTenDN.Text;
            string matkhau = txtTenDN.Text;
            string email = txtEmail.Text;
            string chucvu = txtChucVu.Text;
            string trangthai = txtTrangThai.Text;
            if (string.IsNullOrEmpty(matk) && string.IsNullOrEmpty(tendn)
                && string.IsNullOrEmpty(matkhau) && string.IsNullOrEmpty(chucvu)
                && string.IsNullOrEmpty(trangthai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                tkbo.SuaTK(matk, tendn, matkhau, email, false, trangthai);
            }
        }
    }
}
