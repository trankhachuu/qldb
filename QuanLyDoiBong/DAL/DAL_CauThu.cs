using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyDoiBong.DAL
{
    class DAL_CauThu : ConnectDatabase
    {
        public DataTable getDSCauThu()
        {
            return getTable("select * from [CAUTHU]");
        }

        public int insertCauThu(string tenCauThu, string ngaySinh, string gioiTinh, string kyNang, string ngayGiaNhap, string ChieuCao, string ngayHopDong, string luong, string maDB)
        {
            string sql = "insert into [CAUTHU] values(N'" + tenCauThu + "', N'" + ngaySinh + "', N'" + gioiTinh + "', N'" + kyNang + "', N'" + ngayGiaNhap + "', N'" + ChieuCao + "', N'" + ngayHopDong + "', " + luong + ", " + maDB + ")";
            return excuteNonQuery(sql);
        }

        public int updateCauThu(string maCT, string tenCauThu, string ngaySinh, string gioiTinh, string kyNang, string ngayGiaNhap, string ChieuCao, string ngayHopDong, string luong, string maDB)
        {
            string sql = "update [CAUTHU] set TenCT = N'"+tenCauThu+"', NgaySinh = N'"+ngaySinh+"', GioiTinh = N'"+gioiTinh+"', KyNang = N'"+kyNang+"', NgayGiaNhap = N'"+ngayGiaNhap+"', ChieuCao = N'"+ChieuCao+"', NgayHetHopDong = N'"+ngayHopDong+"', Luong = "+luong+", MaDB = "+maDB+" where MaCT = " + maCT;
            return excuteNonQuery(sql);
        }

        public int deleteCauThu(string maCT)
        {
            string sql = "delete from [CAUTHU] where MaCT = " + maCT;
            return excuteNonQuery(sql);
        }
    }
}
