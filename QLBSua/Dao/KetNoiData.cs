using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Dao
{
    public class KetNoiData
    {
        //B1: khai báo chuỗi kết nối
        public string connectionString = "Data Source=DESKTOP-RQV86U4;Initial Catalog=QLBS;User ID=sa;Password=truongminhhung";
        public SqlConnection sqlConn = null;
        public void MoKetNoi()
        {
            sqlConn = new SqlConnection(connectionString);
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }   
        }
        
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            MoKetNoi();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConn);
            sqlData.Fill(dt);
            DongKetNoi();
            sqlData.Dispose();
            return dt;
        }

        public void ChangeData(string sql)
        {
            MoKetNoi();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = sql;
            sqlComm.ExecuteNonQuery();
            DongKetNoi();
            sqlComm.Dispose();
        }

        public void DongKetNoi()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }
    }
}
