using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Dao
{
    public class HoaDonThanhToanDao
    {
        public HoaDonThanhToan getNgayMua(int hdid)
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select DISTINCT ngaymua" +
                    "\r\nfrom viewHoaDonThanhToan" +
                    " \r\nwhere mahd = @MaHD";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaHD", hdid);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime ngaymua = reader.GetDateTime("ngaymua");
                    return new HoaDonThanhToan(ngaymua);
                }
                kn.DongKetNoi();
            }
            catch (Exception ex)
            {

            }
            return null;
        }
        public List<HoaDonThanhToan> getSPbyMaHD(long hdid)
        {
            List<HoaDonThanhToan> ls = new List<HoaDonThanhToan>();
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select * from viewHoaDonThanhToan where mahd = @MaHD";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaHD", hdid);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int matk = reader.GetInt32("matk");
                    string tensp = reader.GetString("tensp");
                    double gia = reader.GetDouble("gia");
                    int giamgia = reader.GetInt32("giamgia");
                    int soluongmua = reader.GetInt32("soluongmua");
                    int mahd = reader.GetInt32("mahd");
                    bool damua = reader.GetBoolean("damua");
                    double thanhtien = reader.GetDouble("thanhtien");
                    DateTime ngaymua = reader.GetDateTime("ngaymua");
                    ls.Add(new HoaDonThanhToan(matk, tensp, gia, giamgia, soluongmua, mahd,
                        damua, thanhtien, ngaymua));
                }
                kn.DongKetNoi();
                return ls;
            }catch(Exception e)
            {
                return null;
            }
        }
        public List<HoaDonThanhToan> getSPbyMaTK(long tkid)
        {
            List<HoaDonThanhToan> ls = new List<HoaDonThanhToan>();
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select * from viewHoaDonThanhToan where matk = @MaTK";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaTK", tkid);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int matk = reader.GetInt32("matk");
                    string tensp = reader.GetString("tensp");
                    double gia = reader.GetDouble("gia");
                    int giamgia = reader.GetInt32("giamgia");
                    int soluongmua = reader.GetInt32("soluongmua");
                    int mahd = reader.GetInt32("mahd");
                    bool damua = reader.GetBoolean("damua");
                    double thanhtien = reader.GetDouble("thanhtien");
                    DateTime ngaymua = reader.GetDateTime("ngaymua");
                    ls.Add(new HoaDonThanhToan(matk, tensp, gia, giamgia, soluongmua, mahd,
                        damua, thanhtien, ngaymua));
                }
                kn.DongKetNoi();
                return ls;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public double TongTienBanDuoc()
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select sum(thanhtien)" +
                    "\r\nfrom viewhoadonthanhtoan\r\nwhere damua = 1";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetDouble(0);
                }
                kn.DongKetNoi();
            }
            catch (Exception e)
            {
                
            }
            return 0;
        }
        public int TongSoLuongBanDuoc()
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select sum(soluongmua) " +
                    "from viewhoadonthanhtoan " +
                    "where damua = 1";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                kn.DongKetNoi();
            }
            catch (Exception e)
            {

            }
            return 0;
        }
    }
}
