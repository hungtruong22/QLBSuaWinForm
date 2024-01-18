using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBSua.Dao
{
    public class LoaiDao
    {
        public List<Loai> getLoai()
        {
            List<Loai> ls = new List<Loai> ();
            KetNoiData kn = new KetNoiData ();
            kn.MoKetNoi();
            string sql = "select * from Loai";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string maloai = reader.GetString(0);
                string tenloai = reader.GetString(1);
                ls.Add(new Loai(maloai, tenloai));
            }
            return ls;
            kn.DongKetNoi();
        }
        public void ThemLoai(string mal, string tenl)
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "insert into Loai(maloai, tenloai) values(@MaLoai, @TenLoai)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaLoai", mal);
                cmd.Parameters.AddWithValue("@TenLoai", tenl);
                cmd.ExecuteNonQuery();
                kn.DongKetNoi();
            }
            catch (Exception ex)
            {

            }
        }
        public void SuaLoai(string mal, string tenl)
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "update Loai set tenloai = @TenLoai where maloai = @MaLoai";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaLoai", mal);
                cmd.Parameters.AddWithValue("@TenLoai", tenl);
                cmd.ExecuteNonQuery();
                kn.DongKetNoi();
            }
            catch (Exception ex)
            {

            }
        }

        public void XoaLoai(string loaiid)
        {
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            string sql = "delete from Loai where maloai = @MaLoai";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@MaLoai", loaiid);
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }

        public List<Loai> TimKiemLoai(string loainame)
        {
            try
            {
                List<Loai> ls = new List<Loai>();
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select * from Loai" +
                    " where tenloai like @TenLoai";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@TenLoai", "%" + loainame + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maloai = reader.GetString("maloai");
                    string tenloai = reader.GetString("tenloai");
                    ls.Add(new Loai(maloai, tenloai));
                }
                return ls;
                kn.DongKetNoi();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<Loai> getLoaiByMaLoai(string mloai)
        {
            List<Loai> lssp = new List<Loai>();
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            try
            {
                string sql = "select * from Loai where Loai.maloai = @MaLoai";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaLoai", mloai);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maloai = reader.GetString("maloai");
                    string tenloai = reader.GetString("tenloai");
                    lssp.Add(new Loai(maloai, tenloai));
                }
                return lssp;
            }
            catch (Exception ex)
            {

            }
            return null;
            kn.DongKetNoi();
        }
    }
}
