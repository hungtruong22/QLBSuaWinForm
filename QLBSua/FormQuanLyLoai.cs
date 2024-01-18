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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBSua
{
    public partial class FormQuanLyLoai : Form
    {
        LoaiBo lbo = new LoaiBo();
        public FormQuanLyLoai()
        {
            InitializeComponent();
            HienThiLoai();
        }

        void HienThiLoai()
        {
            List<Loai> ls = lbo.getLoai();
            loaiBindingSource.DataSource = null;
            loaiBindingSource.DataSource = ls;
        }

        void HienThiThongTinLoai(Loai loai)
        {
            txtMaLoai.Text = loai.maloai;
            txtTenLoai.Text = loai.tenloai;
        }

        private void RefreshDataGridView()
        {
            // Liên kết DataGridView với danh sách sản phẩm
            loaiBindingSource.DataSource = null;
            loaiBindingSource.DataSource = lbo.getLoai();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loai loai = loaiBindingSource.Current as Loai;
            HienThiThongTinLoai(loai);
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            string maloai = txtMaLoai.Text.Trim();
            string tenloai = txtTenLoai.Text.Trim();
            if (string.IsNullOrEmpty(maloai) && string.IsNullOrEmpty(tenloai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (lbo.getLoaiByMaLoai(maloai).Count != 0)
                {
                    MessageBox.Show("Đã tồn tại Mã Loại này");
                }
                else
                {
                    lbo.ThemLoai(maloai, tenloai);
                    MessageBox.Show("Thêm loại thành công");
                    RefreshDataGridView();
                }
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            string maloai = txtMaLoai.Text.Trim();
            string tenloai = txtTenLoai.Text.Trim();
            lbo.SuaLoai(maloai, tenloai);
            MessageBox.Show("Cập nhật thông tin loại thành công");
            RefreshDataGridView();
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            Loai loai = loaiBindingSource.Current as Loai;
            string mloai = loai.maloai;
            var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                lbo.XoaLoai(mloai);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                RefreshDataGridView();
            }
        }

        private void btnTimKiemLoai_Click(object sender, EventArgs e)
        {
            string key = Interaction.InputBox("Nhập tên Loại", "Tìm kiếm Loại");
            List<Loai> lstimkiem = lbo.TimKiemLoai(key.ToLower().Trim());
            loaiBindingSource.DataSource = lstimkiem;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormTrangChuAdmin();
            f.ShowDialog();
        }

        private void btnHienThiLoai_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
