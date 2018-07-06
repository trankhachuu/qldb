using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDoiBong.DAL;
using QuanLyDoiBong.GUI;
using System.Data;

namespace QuanLyDoiBong.BUS
{
    class BUS_CauThu
    {
        Frm_CauThu frmCT;
        DAL_CauThu da_CT;
        public BUS_CauThu(Frm_CauThu frm)
        {
            frmCT = frm;
            da_CT = new DAL_CauThu();
        }

        public void setComboDoiBong()
        {
            //frmCT.cb_DoiBong.DataSource = da_CT.
        }

        public void setDataGrid()
        {
            frmCT.dataGridView1.DataSource = da_CT.getDSCauThu();
        }

        public int insert()
        {
            return da_CT.insertCauThu(frmCT.txt_Ten.Text, frmCT.txtNgaySnh.Text, frmCT.txt_GioiTinh.Text, frmCT.txt_KyNang.Text, frmCT.txt_NgayGiaNhap.Text, frmCT.txt_ChieuCao.Text, frmCT.txt_NgayHetHopDong.Text, frmCT.txt_Luong.Text, frmCT.cb_DoiBong.SelectedValue.ToString());
        }

        public int update()
        {
            return da_CT.updateCauThu(frmCT.txt_Ma.Text, frmCT.txt_Ten.Text, frmCT.txtNgaySnh.Text, frmCT.txt_GioiTinh.Text, frmCT.txt_KyNang.Text, frmCT.txt_NgayGiaNhap.Text, frmCT.txt_ChieuCao.Text, frmCT.txt_NgayHetHopDong.Text, frmCT.txt_Luong.Text, frmCT.cb_DoiBong.SelectedValue.ToString());
        }

        public int delete()
        {
            return da_CT.deleteCauThu(frmCT.txt_Ma.Text);
        }
    }
}
