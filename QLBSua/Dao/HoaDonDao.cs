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
    public class HoaDonDao
    {
        public long maxhd()
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select max(mahd) as maxhd  from HoaDon";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                long kq = 0;
                if (reader.Read())
                {
                    kq = reader.GetInt32("maxhd");
                }
                return kq;
                kn.DongKetNoi();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int ThemHD(int tkid)
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "insert into HoaDon(matk,ngaymua,damua)" +
                    " values(@MaTK, @NgayMua, @DaMua)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaTK", tkid);
                cmd.Parameters.AddWithValue("@NgayMua", DateTime.Now);
                cmd.Parameters.AddWithValue("@DaMua", true);
                int kq = cmd.ExecuteNonQuery();
                return kq;
                kn.DongKetNoi();
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        public List<HoaDon> GetHD()
        {
            List<HoaDon> ls = new List<HoaDon>();
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select * from HoaDon";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    int mahd = reader.GetInt32("mahd");
                    int matk = reader.GetInt32("matk");
                    DateTime ngaymua = reader.GetDateTime("ngaymua");
                    bool damua = reader.GetBoolean("damua");
                    ls.Add(new HoaDon(mahd, matk, ngaymua, damua));
                }
                kn.DongKetNoi();
                return ls;
            }catch(Exception ex)
            {
                return null;
            }
        }
        public int TongHD()
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select count(mahd) from HoaDon";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            catch(Exception e)
            {
                return 0;
            }
            return 0;
        }
    }
}
