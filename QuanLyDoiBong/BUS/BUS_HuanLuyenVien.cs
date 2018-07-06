using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDoiBong.GUI;
using QuanLyDoiBong.DAL;
using System.Data;

namespace QuanLyDoiBong.BUS
{
    class BUS_HuanLuyenVien
    {
        Frm_HuanLuyenVien frmHLV;
        DAL_HuanLuyenVien da_HLV;
        DAL_DoiBong da_DoiBong;

        public BUS_HuanLuyenVien(Frm_HuanLuyenVien frm)
        {
            this.frmHLV = frm;
            da_HLV = new DAL_HuanLuyenVien();
            da_DoiBong = new DAL_DoiBong();
        }

        public void setComboDoiBong()
        {

        }

        public void setDataGrid(){
            frmHLV.dataGridView1.DataSource = da_HLV.getDSHuanLuyenVien();
        }

        public int insert()
        {
            return da_HLV.insertHuanLuyenVien(frmHLV.txt_Ten.Text, frmHLV.txt_NgayGiaNhap.Text, frmHLV.txt_NgayHetHopDong.Text, frmHLV.txt_Luong.Text, frmHLV.cb_DoiBong.SelectedValue.ToString());
        }

        public int update()
        {
            return da_HLV.updateHuanLuyenVien(frmHLV.txt_Ma.Text, frmHLV.txt_Ten.Text, frmHLV.txt_NgayGiaNhap.Text, frmHLV.txt_NgayHetHopDong.Text, frmHLV.txt_Luong.Text, frmHLV.cb_DoiBong.SelectedValue.ToString());
        }

        public int delete()
        {
            return da_HLV.deleteHuanLuyenVien(frmHLV.txt_Ma.Text);
        }
    }
}
