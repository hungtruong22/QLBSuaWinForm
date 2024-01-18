using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLBSua.Dao
{
    internal class TaiKhoanDao
    {
        public TaiKhoan Login(string emailtk, string matkhautk)
        {
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            string sql = "SELECT * FROM TaiKhoan WHERE TaiKhoan.email = @Email AND TaiKhoan.matkhau = @MatKhau";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@Email", emailtk);
            cmd.Parameters.AddWithValue("@MatKhau", matkhautk);
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int matk = (int)reader.GetInt32("matk");
                string email = reader.GetString("email");
                string tendn = reader.GetString("tendn");
                string matkhau = reader.GetString("matkhau");
                bool isAdmin = reader.GetBoolean("isAdmin");
                string trangthai = reader.GetString("trangthai");
                return new TaiKhoan(matk, email, tendn, matkhau, isAdmin, trangthai);
            }
            return null;
            kn.DongKetNoi();
        }

        public TaiKhoan Kiemtrataikhoantontai(string etk)
        {
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            // B3: Khai báo lệnh sql
            string sql = "select * from TaiKhoan\r\n"
                    + "where TaiKhoan.email=@Email";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Email", etk);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int matk = (int)reader.GetInt32("matk");
                string email = reader.GetString("email");
                string tendn = reader.GetString("tendn");
                string matkhau = reader.GetString("matkhau");
                bool isAdmin = reader.GetBoolean("isAdmin");
                string trangthai = reader.GetString("trangthai");
                return new TaiKhoan(matk, email, tendn, matkhau, isAdmin, trangthai);
            }
            return null;
            kn.DongKetNoi();
        }

        public void SignUp(string tendntk, string matkhautk,string emailtk)
        {
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            string sql = "insert into TaiKhoan\r\n"
                            + "values(@TenDN, @MatKhau, @Email, 0, @TrangThai)";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@TenDN", tendntk);
            cmd.Parameters.AddWithValue("@MatKhau", matkhautk);
            cmd.Parameters.AddWithValue("@Email", emailtk);
            cmd.Parameters.AddWithValue("@TrangThai", "Bình thường");
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            cmd.ExecuteNonQuery();
        }
        public void CapNhatTrangThai(int tkid, string trangthaitk)
        {
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            string sql = "update TaiKhoan set TaiKhoan.trangthai = @TrangThai" +
                " where TaiKhoan.matk = @MaTK";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@TrangThai", trangthaitk);
            cmd.Parameters.AddWithValue("@MaTK", tkid);
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }
        public int TongSLNhanVien()
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "select count(matk) from TaiKhoan";
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
            catch (Exception ex)
            {

            }
            return 0;
        }
        public void DoiMK(int matk, string matkhau)
        {
            KetNoiData kn = new KetNoiData();
            kn.MoKetNoi();
            string sql = "update TaiKhoan set matkhau = @MatKhau " +
                "where matk = @MaTK";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@MatKhau", matkhau);
            cmd.Parameters.AddWithValue("@MaTK", matk);
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }
        public void SuaTK(string tkid, string tendn, string mk, string email, bool isAdmin, string tthai)
        {
            try
            {
                KetNoiData kn = new KetNoiData();
                kn.MoKetNoi();
                string sql = "update TaiKhoan set tendn = @TenDN, matkhau = @MatKhau, email = @Email, " +
                    "isAdmin = @IsAdmin, trangthai = @TrangThai" +
                "where matk = @MaTK";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@TenDN", tendn);
                cmd.Parameters.AddWithValue("@MatKhau", mk);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@IsAdmin", isAdmin);
                cmd.Parameters.AddWithValue("@TrangThai", tthai);
                cmd.ExecuteNonQuery();
                kn.DongKetNoi();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
