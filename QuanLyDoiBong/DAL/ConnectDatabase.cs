using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDoiBong.DAL
{
    class ConnectDatabase
    {
        string connectionString = "";
        SqlConnection conn;
        public ConnectDatabase()
        {
            conn = new SqlConnection(connectionString);
        }

        public void connect()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void disConnect() {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public int excuteNonQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            disConnect();
            return kq;
        }

        public DataTable getTable(string sql)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
