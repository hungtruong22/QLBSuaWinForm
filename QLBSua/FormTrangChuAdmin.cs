using Microsoft.VisualBasic;
using QLBSua.Bo;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBSua
{
    public partial class FormTrangChuAdmin : Form
    {
        LoaiBo lbo = new LoaiBo();
        SanPhamBo spbo = new SanPhamBo();
        TaiKhoanBo tkbo = new TaiKhoanBo();
        HoaDonBo hdbo = new HoaDonBo();
        ChiTietHoaDonBo ctbo = new ChiTietHoaDonBo();
        public FormTrangChuAdmin()
        {
            InitializeComponent();
            lbTenDN.Text = FormDangNhap.tk.tendn;
            if (FormDangNhap.tk.isAdmin == false)
            {
                lbChucVu.Text = "Nhân Viên";
            }
            else
            {
                lbChucVu.Text = "Admin";
            }
            HienThiLoai();
            HienThiSanPham();
        }
        void HienThiLoai()
        {
            List<Loai> lsloai = lbo.getLoai();
            foreach (Loai l in lsloai)
            {
                cbbLoaiSP.Items.Add(l.tenloai);
            }
            cbbLoaiSP.SelectedIndex = 2;
        }

        void HienThiSanPham()
        {
            List<SanPham> lssanpham = spbo.getSP();
            sanPhamBindingSource.DataSource = lssanpham;
        }

        void HienThiThongTinSanPham(SanPham sp)
        {
            txtTenSP.Text = sp.tensp;
            txtGia.Text = sp.gia.ToString();
            txtSoLuongHienCo.Text = sp.soluong.ToString();
            txtGiamGia.Text = sp.giamgia.ToString();
            txtTenLoai.Text = sp.tenloai;
            txtGiaDaGiam.Text = (sp.gia - (sp.gia * sp.giamgia / 100)).ToString();
        }
        private void RefreshDataGridView()
        {
            // Liên kết DataGridView với danh sách sản phẩm
            sanPhamBindingSource.DataSource = null;
            sanPhamBindingSource.DataSource = spbo.getSP();
        }

        void TinhTongThanhToanVaSoLuongMua()
        {
            double sum = 0;
            int slm = 0;
            foreach (DataGridViewRow item in dgvGHang.Rows)
            {
                if (item.Cells["soluongmua"].Value != null
                    && item.Cells["thanhtien"].Value != null)
                {
                    slm = int.Parse(item.Cells["soluongmua"].Value.ToString()) + slm;
                    sum = double.Parse(item.Cells["thanhtien"].Value.ToString()) + sum;
                }
            }
            txtTongSLM.Text = slm.ToString();
            txtTongThanhToan.Text = sum.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormTrangChuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            tkbo.CapNhatTrangThai(FormDangNhap.tk.matk, "Bình thường");
            this.Hide();
            var f = new FormDangNhap();
            f.ShowDialog();
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SanPham sp = sanPhamBindingSource.Current as SanPham;
            HienThiThongTinSanPham(sp);
        }

        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SanPham> ls = spbo.getSPByLoai(cbbLoaiSP.SelectedItem.ToString());
            sanPhamBindingSource.DataSource = ls;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = Interaction.InputBox("Nhập tên SP", "Tìm kiếm SP");
            List<SanPham> lstimkiem = spbo.TimKiemSP(key.ToLower().Trim());
            sanPhamBindingSource.DataSource = lstimkiem;
        }

        private void btnThongTinSP_Click(object sender, EventArgs e)
        {
            SanPham sp = sanPhamBindingSource.Current as SanPham;
            this.Hide();
            var f = new FormThongTinSP(sp);
            f.ShowDialog();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormThongTinSP(null);
            f.ShowDialog();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            SanPham sp = sanPhamBindingSource.Current as SanPham;
            this.Hide();
            var f = new FormThongTinSP(sp);
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPham sp = sanPhamBindingSource.Current as SanPham;
            string msp = sp.masp;
            var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                spbo.XoaSP(msp);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                RefreshDataGridView();
            }
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormThongTinCaNhan(FormDangNhap.tk);
            f.ShowDialog();
        }
        /*List<SanPham> lstsp = new List<SanPham>();*/
        private void btnThemGH_Click(object sender, EventArgs e)
        {
            SanPham sp = sanPhamBindingSource.Current as SanPham;
            Image anhSP = Image.FromFile(sp.anh.ToString());
            int slm = 1;
            double giadagiam = (sp.gia - (sp.gia * sp.giamgia / 100));
            double thanhtien = slm * giadagiam;
            foreach (DataGridViewRow item in dgvGHang.Rows)
            {
                // sản phẩm tồn tại thì tăng sl lên thêm 1
                if (item.Cells["masp"].Value == sp.masp)
                {
                    item.Cells["soluongmua"].Value
                        = int.Parse(item.Cells["soluongmua"].Value.ToString()) + 1;
                    item.Cells["thanhtien"].Value
                        = double.Parse(item.Cells["giadagiam"].Value.ToString())
                        * int.Parse(item.Cells["soluongmua"].Value.ToString());
                    TinhTongThanhToanVaSoLuongMua();
                    return;
                }
            }
            dgvGHang.Rows.Add(new object[] {sp.masp, sp.tensp, anhSP, sp.gia, sp.giamgia,
                (sp.gia - (sp.gia * sp.giamgia / 100)), 1,
                (sp.gia - (sp.gia * sp.giamgia / 100)) * 1});
            TinhTongThanhToanVaSoLuongMua();
        }

        private void dgvGHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvGHang.Rows[e.RowIndex];
            txtTSP.Text = row.Cells["tensp"].Value.ToString();
            txtNhapSL.Text = row.Cells["soluongmua"].Value.ToString();
            string columnName = dgvGHang.Columns[e.ColumnIndex].Name;
            if (columnName == "xoaspgh")
            {
                dgvGHang.Rows.Remove(row);
                txtTSP.Text = "";
                txtNhapSL.Text = "";
                TinhTongThanhToanVaSoLuongMua();
            }
        }

        private void btnCapNhatSL_Click(object sender, EventArgs e)
        {
            string tsp = txtTSP.Text;
            double slm = double.Parse(txtNhapSL.Text);
            foreach (DataGridViewRow item in dgvGHang.Rows)
            {
                if (item.Cells["tensp"].Value != null && !string.IsNullOrEmpty(tsp))
                {
                    if (item.Cells["tensp"].Value.Equals(tsp))
                    {
                        // cap nhat so luong
                        item.Cells["soluongmua"].Value
                            = slm;
                        item.Cells["thanhtien"].Value
                            = double.Parse(item.Cells["giadagiam"].Value.ToString())
                            * int.Parse(item.Cells["soluongmua"].Value.ToString());
                        TinhTongThanhToanVaSoLuongMua();
                        return;
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int slm = int.Parse(txtTongSLM.Text);
            double tongthanhtoan = double.Parse(txtTongThanhToan.Text);
            hdbo.ThemHD(FormDangNhap.tk.matk);
            long maxmahd = hdbo.maxhd();
            foreach (DataGridViewRow item in dgvGHang.Rows)
            {
                if (item.Cells["masp"].Value != null && item.Cells["tensp"].Value != null &&
                    item.Cells["soluongmua"].Value != null)
                {
                    ctbo.ThemCTHD(item.Cells["masp"].Value.ToString(),
                    item.Cells["tensp"].Value.ToString(),
                    int.Parse(item.Cells["soluongmua"].Value.ToString()), maxmahd);
                }
                /*ctbo.getNewMaHd();*/
            }
            dgvGHang.Rows.Clear();
            var f = new FormHoaDon(FormDangNhap.tk, DateTime.Now, maxmahd, slm, tongthanhtoan);
            f.ShowDialog();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormLichSu(FormDangNhap.tk);
            f.ShowDialog();
        }

        private void btnQLLoai_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormQuanLyLoai();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormThongKe();
            f.ShowDialog();
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormQuanLyHoaDon();
            f.ShowDialog();
        }
    }
}
