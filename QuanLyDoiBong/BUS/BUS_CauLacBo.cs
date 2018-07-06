using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDoiBong.GUI;
using QuanLyDoiBong.DAL;

namespace QuanLyDoiBong.BUS
{
    class BUS_CauLacBo
    {
        Frm_CauLacBo form_caulacbo;
        DAL_CauLacBo da_clb;

        public BUS_CauLacBo(Frm_CauLacBo form_caulacbo)
        {
            this.form_caulacbo = form_caulacbo;
            da_clb = new DAL_CauLacBo(); 
        }

        public void setDataGridView()
        {
            form_caulacbo.dtg_CauLacBo.DataSource = da_clb.getCauLacBo();
            form_caulacbo.dtg_CauLacBo.Columns[0].HeaderText = "Mã Câu Lạc Bộ";
            form_caulacbo.dtg_CauLacBo.Columns[1].HeaderText = "Tên Câu Lạc Bộ";
        }

        public int insert()
        {
            int kq = da_clb.insertCauLacBo(form_caulacbo.txt_tenclb.Text);
            return kq;

        }

        public int update()
        {
            return da_clb.insertCauLacBo(form_caulacbo.txt_maclb.Text);
        }

        public int delete()
        {
            return da_clb.deleteCauLacBo(form_caulacbo.txt_maclb.Text);
        }
    }
}
