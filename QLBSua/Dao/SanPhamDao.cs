using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Dao
{
    public class SanPhamDao
    {
        public List<SanPham> getSP()
        {
            List<SanPham> ls = new List<SanPham>();
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            try
            {
                string sql = "select * from SanPham";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string masp = reader.GetString("masp");
                    string tensp = reader.GetString("tensp");
                    int soluong = reader.GetInt32("soluong");
                    double gia = reader.GetDouble("gia");
                    int giamgia = reader.GetInt32("giamgia");
                    string anh = reader.GetString("anh");
                    string malloai = reader.GetString("maloai");
                    string tenloai = reader.GetString("tenloai");
                    ls.Add(new SanPham(masp, tensp, soluong, gia, giamgia, anh, malloai, tenloai));
                }
                return ls;
            }
            catch(Exception ex)
            {
                return null;
            }
            kn.DongKetNoi();
        }

        public List<SanPham> getSPByLoai(string tloai)
        {
            List<SanPham> lssp = new List<SanPham>();
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            try
            {
                string sql = "select * from SanPham where SanPham.tenloai = @TenLoai";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@TenLoai", tloai);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string masp = reader.GetString("masp");
                    string tensp = reader.GetString("tensp");
                    int soluong = reader.GetInt32("soluong");
                    double gia = reader.GetDouble("gia");
                    int giamgia = reader.GetInt32("giamgia");
                    string anh = reader.GetString("anh");
                    string maloai = reader.GetString("maloai");
                    string tenloai = reader.GetString("tenloai");
                    lssp.Add(new SanPham(masp, tensp, soluong, gia, giamgia, anh, maloai, tenloai));
                }
                return lssp;
            }
            catch(Exception ex)
            {
                return null;
            }
            kn.DongKetNoi();
        }

        public void ThemSP(string spid, string spname, int sl, double giasp,
            int giamgiasp, string anhsp, string maloaisp, string tenloaisp)
        {
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            string sql = "insert into SanPham(masp, tensp, soluong, gia, giamgia, anh, maloai, tenloai)" +
                "values(@MaSP, @TenSP, @SoLuong, @Gia, @GiamGia, @Anh, @MaLoai, @TenLoai)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@MaSP", spid);
            cmd.Parameters.AddWithValue("@TenSP", spname);
            cmd.Parameters.AddWithValue("@SoLuong", sl);
            cmd.Parameters.AddWithValue("@Gia", giasp);
            cmd.Parameters.AddWithValue("@GiamGia", giamgiasp);
            cmd.Parameters.AddWithValue("@Anh", anhsp);
            cmd.Parameters.AddWithValue("@MaLoai", maloaisp);
            cmd.Parameters.AddWithValue("@TenLoai", tenloaisp);
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }

        public void SuaSP(string spid, string spname, int sl, double giasp,
            int giamgiasp, string anhsp, string maloaisp, string tenloaisp)
        {
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            string sql = "update SanPham set tensp = @TenSP, soluong = @SoLuong, gia = @Gia," +
                " giamgia = @GiamGia, anh = @Anh, maloai = @MaLoai, tenloai = @TenLoai" +
                " where masp = @MaSP";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@TenSP", spname);
            cmd.Parameters.AddWithValue("@SoLuong", sl);
            cmd.Parameters.AddWithValue("@Gia", giasp);
            cmd.Parameters.AddWithValue("@GiamGia", giamgiasp);
            cmd.Parameters.AddWithValue("Anh", anhsp);
            cmd.Parameters.AddWithValue("@MaLoai", maloaisp);
            cmd.Parameters.AddWithValue("@TenLoai", tenloaisp);
            cmd.Parameters.AddWithValue("@MaSP", spid);
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }

        public void XoaSP(string spid)
        {
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            string sql = "delete from SanPham where masp = @MaSP";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@MaSP", spid);
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }

        public List<SanPham> TimKiemSP(string spname)
        {
            List<SanPham> ls = new List<SanPham>();
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            string sql = "select * from SanPham" +
                " where tensp like @TenSP";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@TenSP", "%" + spname + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString("masp");
                string tensp = reader.GetString("tensp");
                int soluong = reader.GetInt32("soluong");
                double gia = reader.GetDouble("gia");
                int giamgia = reader.GetInt32("giamgia");
                string anh = reader.GetString("anh");
                string maloai = reader.GetString("maloai");
                string tenloai = reader.GetString("tenloai");
                ls.Add(new SanPham(masp, tensp, soluong, gia, giamgia, anh, maloai, tenloai));
            }
            return ls;
            kn.DongKetNoi();
        }
        public List<SanPham> getSPByMaSP(string msp)
        {
            List<SanPham> lssp = new List<SanPham>();
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            try
            {
                string sql = "select * from SanPham where SanPham.masp = @MaSP";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaSP", msp);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string masp = reader.GetString("masp");
                    string tensp = reader.GetString("tensp");
                    int soluong = reader.GetInt32("soluong");
                    double gia = reader.GetDouble("gia");
                    int giamgia = reader.GetInt32("giamgia");
                    string anh = reader.GetString("anh");
                    string maloai = reader.GetString("maloai");
                    string tenloai = reader.GetString("tenloai");
                    lssp.Add(new SanPham(masp, tensp, soluong, gia, giamgia, anh, maloai, tenloai));
                }
                return lssp;
            }
            catch(Exception ex)
            {
                
            }
            return null;
            kn.DongKetNoi();
        }
    }
}
