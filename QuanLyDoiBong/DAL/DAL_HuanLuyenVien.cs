using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyDoiBong.DAL
{
    class DAL_HuanLuyenVien:ConnectDatabase
    {
        public DataTable getDSHuanLuyenVien()
        {
            return getTable("select * from [HUANLUYENVIEN]");
        }

        public int insertHuanLuyenVien(string tenHLV, string ngayGiaNhap, string ngayHetHopDong, string Luong, string maDB)
        {
            string sql = "insert into [HUANLUYENVIEN] values (N'" + tenHLV + "', N'" + ngayGiaNhap + "',N'" + ngayHetHopDong + "', " + Luong + ", " + maDB + ")";
            return excuteNonQuery(sql);
        }

        public int updateHuanLuyenVien(string maHLV, string tenHLV, string ngayGiaNhap, string ngayHetHopDong, string Luong, string maDB)
        {
            string sql = "update [HUANLUYENVIEN] set TenHLV = N'" + tenHLV + "', NgayGiaNhap = N'" + ngayGiaNhap + "', NgayHetHopDong = N'" + ngayHetHopDong + "', Luong = " + Luong + ", MaDB = " + maDB + " where MaHLV = " + maHLV;
            return excuteNonQuery(sql);
        }

        public int deleteHuanLuyenVien(string maHLV)
        {
            return excuteNonQuery("delete from [HUANLUYENVIEN] where MaHLV = " + maHLV);
        }
    }
}
