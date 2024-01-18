using QLBSua.Bo;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLBSua
{
    public partial class FormDangKy : Form
    {
        TaiKhoanBo tkbo = new TaiKhoanBo();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var f = new FormDangNhap();
            f.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string tendn = txtTenDN.Text;
            string matkhau = txtMatKhau.Text;
            string nhaplaimatkhau = txtNhapLaiMatKhau.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matkhau)
                || string.IsNullOrEmpty(tendn) || string.IsNullOrEmpty(nhaplaimatkhau))
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin!");
            }
            else
            {
                if (!matkhau.Equals(nhaplaimatkhau))
                {
                    MessageBox.Show("Mật khẩu nhập lại không trùng khớp với mật khẩu vừa nhập!\n Vui lòng nhập lại");
                }
                else
                {
                    TaiKhoan tk = tkbo.Kiemtrataikhoantontai(email);
                    if (tk == null)
                    {
                        tkbo.SignUp(tendn, matkhau, email);
                        MessageBox.Show("Đăng ký tài khoản thành công");
                        this.Hide();
                        var f = new FormDangNhap();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản này đã tồn tại");
                    }
                }

            }
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
