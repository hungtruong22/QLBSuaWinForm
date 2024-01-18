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
    public class ChiTietHoaDonDao
    {
        public int ThemCTHD(string spid, string spname, int slm, long maxmahd)
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "insert into ChiTietHoaDon(masp, tensp, soluongmua, mahd, damua)" +
                    " values(@MaSP, @TenSP, @SLM, @MaHD, @DaMua)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaSP", spid);
                cmd.Parameters.AddWithValue("@TenSP", spname);
                cmd.Parameters.AddWithValue("@SLM", slm);
                cmd.Parameters.AddWithValue("@MaHD", maxmahd);
                cmd.Parameters.AddWithValue("@DaMua", true);
                int kq = cmd.ExecuteNonQuery();
                return kq;
                kn.DongKetNoi();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public ChiTietHoaDon getNewMaHd()
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select top 1 macthd, mahd, damua from ChiTietHoaDon" +
                    " order by mahd desc";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    int macthd = reader.GetInt32("macthd");
                    int mahd = reader.GetInt32("mahd");
                    bool damua = reader.GetBoolean("damua");
                    return new ChiTietHoaDon(macthd, mahd, damua);
                }
            }catch(Exception ex)
            {
                return null;
            }
            return null;
        }
    }
}
