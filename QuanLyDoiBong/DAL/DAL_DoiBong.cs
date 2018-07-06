using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDoiBong.DAL
{
    class DAL_DoiBong : ConnectDatabase
    {
        public DataTable setDoiBong()
        {
            return getTable("SELECT * FROM [DOIBONG]");
        }

        public int insertDoiBong(string TenDB, string NgayThanhLap)
        {
            string sql = "INSERT INTO [DOIBONG] values('"+ TenDB +"','" + NgayThanhLap + "')";
            return excuteNonQuery(sql);
        }

        public int editDoiBong(string TenDB, string NgayThanhLap)
        {
            string sql= "UPDATE [DOIBONG] SET tendoibong= '"+ TenDB+"', NgayThanhLap= '"+ NgayThanhLap +"'";
            return excuteNonQuery(sql);
        }

        public int delete(string MaDB)
        {
            return excuteNonQuery("DELETE FROM [DOIBONG] WHERE MaDB= '"+ MaDB+"'");
        }
    }
}
