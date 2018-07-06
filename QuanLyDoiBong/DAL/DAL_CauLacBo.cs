using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDoiBong.DAL
{
    class DAL_CauLacBo: ConnectDatabase
    {
        public DataTable getCauLacBo()
        {
            return getTable("SELECT * FORM [CAULACBO]");
        }

        public int insertCauLacBo(string TenCLB)
        {
            string sql = "insert into [CAULACBO] values('" + TenCLB + "')";
            return excuteNonQuery(sql);
        }

        public int editCauLacBo(string TenCLB)
        {
            string sql = "UPDATE [CAULACBO] SET tencaulacbo= '" + TenCLB + "'";
            return excuteNonQuery(sql);
        }

        public int deleteCauLacBo(string MaCLB)
        {
            string sql = "DELETE FROM [CAULACBO] WHERE MaCLB = '" + MaCLB + "'";
            return excuteNonQuery(sql);
        }
    }
}
