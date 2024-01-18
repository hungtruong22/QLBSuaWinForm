using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Dao
{
    public class ThongKeDao
    {
        public List<ThongKe> danhsachbanchay()
        {
            List<ThongKe> ls = new List<ThongKe>();
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select viewHoaDonThanhToan.tensp, SanPham.gia, sum(soluongmua)\r\n\t\t\t\t\t" +
                    "from viewHoaDonThanhToan join SanPham\r\n\t\t\t\t\t" +
                    "on viewHoaDonThanhToan.tensp = SanPham.tensp\r\n\t\t\t\t\t" +
                    "where damua = 1\r\n\t\t\t\t\tgroup by viewHoaDonThanhToan.tensp, SanPham.gia\r\n\t\t\t\t\t" +
                    "having sum(soluongmua) >= all " +
                    "(\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tselect sum(soluongmua)\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t" +
                    "from viewHoaDonThanhToan join SanPham\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t" +
                    "on viewHoaDonThanhToan.tensp = SanPham.tensp\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t" +
                    "where damua = 1\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t" +
                    "group by viewHoaDonThanhToan.tensp)\r\n\t\t\t\t\t";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string tensp = reader.GetString(0);
                    double gia = reader.GetDouble(1);
                    int soluongmua = reader.GetInt32(2);
                    ls.Add(new ThongKe(tensp, gia, soluongmua));
                }
                kn.DongKetNoi();
                return ls;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<ThongKe> danhsachbancham()
        {
            List<ThongKe> ls = new List<ThongKe>();
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select viewHoaDonThanhToan.tensp, SanPham.gia, sum(soluongmua)\r\n\t\t\t\t\t" +
                    "from viewHoaDonThanhToan join SanPham\r\n\t\t\t\t\t" +
                    "on viewHoaDonThanhToan.tensp = SanPham.tensp\r\n\t\t\t\t\t" +
                    "where damua = 1\r\n\t\t\t\t\tgroup by viewHoaDonThanhToan.tensp, SanPham.gia\r\n\t\t\t\t\t" +
                    "having sum(soluongmua) <= all " +
                    "(\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tselect sum(soluongmua)\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t" +
                    "from viewHoaDonThanhToan join SanPham\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t" +
                    "on viewHoaDonThanhToan.tensp = SanPham.tensp\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t" +
                    "where damua = 1\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t" +
                    "group by viewHoaDonThanhToan.tensp)\r\n\t\t\t\t\t";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tensp = reader.GetString(0);
                    double gia = reader.GetDouble(1);
                    int soluongmua = reader.GetInt32(2);
                    ls.Add(new ThongKe(tensp, gia, soluongmua));
                }
                kn.DongKetNoi();
                return ls;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
