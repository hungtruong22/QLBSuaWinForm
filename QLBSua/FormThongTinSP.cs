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
    public partial class FormThongTinSP : Form
    {
        SanPhamBo spbo = new SanPhamBo();
        LoaiBo lbo = new LoaiBo();
        TaiKhoanBo tkbo = new TaiKhoanBo();
        public SanPham? sanpham { get; set; }
        public FormThongTinSP(SanPham sp)
        {
            InitializeComponent();
            this.sanpham = sp;
            if (sp != null)
            {
                HienThiThongTinSanPham(sp);
            }
        }

        void HienThiThongTinSanPham(SanPham sp)
        {
            txtMaSP.Text = sp.masp;
            txtTenSP.Text = sp.tensp;
            txtGia.Text = sp.gia.ToString();
            txtSoLuongHienCo.Text = sp.soluong.ToString();
            txtGiamGia.Text = sp.giamgia.ToString();
            txtMaLoai.Text = sp.maloai;
            txtTenLoai.Text = sp.tenloai;
            txtGiaDaGiam.Text = (sp.gia - (sp.gia * sp.giamgia / 100)).ToString();
            ptbAnhSanPham.ImageLocation = sp.anh;
        }

        private void ptbAnhSanPham_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog()
            {
                Title = "Chọn file ảnh"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFile.FileName;
                ptbAnhSanPham.ImageLocation = selectedFile;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            double gia = double.Parse(txtGia.Text);
            int soluonghienco = int.Parse(txtSoLuongHienCo.Text);
            int giamgia = int.Parse(txtGiamGia.Text);
            double giadagiam = (gia - (gia * giamgia / 100));
            string maloai = txtMaLoai.Text;
            string tenloai = txtTenLoai.Text;
            string anh = ptbAnhSanPham.ImageLocation;
            if (string.IsNullOrEmpty(masp) || string.IsNullOrEmpty(tensp)
                || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(txtSoLuongHienCo.Text)
                || string.IsNullOrEmpty(txtGiamGia.Text) || string.IsNullOrEmpty(txtGiaDaGiam.Text)
                || string.IsNullOrEmpty(maloai) || string.IsNullOrEmpty(tenloai)
                || string.IsNullOrEmpty(anh))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                if (sanpham != null)
                {
                    // Cap nhat
                    spbo.SuaSP(masp, tensp, soluonghienco, gia, giamgia, anh, maloai, tenloai);
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
                    if (FormDangNhap.tk.isAdmin == true)
                    {
                        var f = new FormTrangChuAdmin();
                        f.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        var f = new FormTrangChu();
                        f.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    // Them moi
                    if (spbo.getSPByMaSP(masp).Count != 0)
                    {

                        MessageBox.Show("Đã tồn tại Mã SP này");
                    }
                    else
                    {
                        spbo.ThemSP(masp, tensp, soluonghienco, gia, giamgia, anh, maloai, tenloai);
                        MessageBox.Show("Đã thêm sản phẩm thành công");
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

        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiamGia.Text))
            {
                txtGiamGia.Text = "0";
                txtGiaDaGiam.Text = (double.Parse(txtGia.Text) - (double.Parse(txtGia.Text) * double.Parse(txtGiamGia.Text) / 100)).ToString();
            }
            else
            {
                txtGiaDaGiam.Text = (double.Parse(txtGia.Text) - (double.Parse(txtGia.Text) * double.Parse(txtGiamGia.Text) / 100)).ToString();
            }

        }

        private void btnBoQua_Click(object sender, EventArgs e)
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
