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
    public partial class FormDoiMatKhau : Form
    {
        TaiKhoan? taiKhoan { get; set; }
        TaiKhoanBo tkbo = new TaiKhoanBo();
        public FormDoiMatKhau(TaiKhoan tk)
        {
            this.taiKhoan = tk;
            if (tk != null)
            {
                InitializeComponent();
                lbMaTk.Text = tk.matk.ToString();
                lbTenDN.Text = tk.tendn.ToString();
                lbEmail.Text = tk.email.ToString();
            }

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
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
            string matkhau = txtMK.Text;
            string mkmoi = txtNhapMK.Text;
            string nhaplaimk = txtNhapLaiMK.Text;
            if (string.IsNullOrEmpty(matkhau) && string.IsNullOrEmpty(mkmoi)
                && string.IsNullOrEmpty(nhaplaimk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (taiKhoan.matkhau.Equals(matkhau))
                {
                    if (mkmoi.Equals(nhaplaimk))
                    {
                        tkbo.DoiMK(taiKhoan.matk, mkmoi);
                        MessageBox.Show("Đổi MK thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không trùng khớp với mật khẩu mới!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng! \nVui lòng nhập lại.");
                }
            }
        }
    }
}
