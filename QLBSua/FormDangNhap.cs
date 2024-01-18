using QLBSua.Bo;
using QLBSua.Dao;
using QLBSua.Model;
using System;
using System.Data;
using System.Data.SqlClient;
namespace QLBSua
{
    public partial class FormDangNhap : Form
    {
        TaiKhoanBo tkbo = new TaiKhoanBo();
        public static TaiKhoan tk = null;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string matkhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin!");
            }
            else
            {

                tk = tkbo.Login(email, matkhau);
                if (tk != null)
                {
                    tkbo.CapNhatTrangThai(tk.matk, "Đang hoạt động");
                    /*MessageBox.Show("Đăng nhập thành công");*/
                    if (tk.isAdmin == true)
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
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var f = new FormDangKy();
            f.ShowDialog();
        }

        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}