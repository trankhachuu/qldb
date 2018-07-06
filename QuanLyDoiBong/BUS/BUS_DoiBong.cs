using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDoiBong.GUI;
using QuanLyDoiBong.DAL;

namespace QuanLyDoiBong.BUS
{
    class BUS_DoiBong
    {
        Frm_DoiBong form_doibong;
        DAL_DoiBong da_db;

        public BUS_DoiBong(Frm_DoiBong form_doibong)
        {
            this.form_doibong = form_doibong;
            da_db = new DAL_DoiBong();
        }

        public void setDataGridView()
        {
            form_doibong.dtg_DoiBong.DataSource = da_db.setDoiBong();
            form_doibong.dtg_DoiBong.Columns[0].HeaderText = "Mã Đội Bóng";
            form_doibong.dtg_DoiBong.Columns[0].HeaderText = "Tên Đội Bóng";
            form_doibong.dtg_DoiBong.Columns[0].HeaderText = "Ngày Thành Lập";
            form_doibong.dtg_DoiBong.Columns[0].HeaderText = "Mã Câu Lạc Bộ";
        }

        public int insert()
        {
            return da_db.insertDoiBong(form_doibong.txt_tendb.Text, form_doibong.dateTimePicker1.Text);
        }

        public int update()
        {
            return da_db.editDoiBong(form_doibong.txt_tendb.Text, form_doibong.dateTimePicker1.Text);
        }

        public int delete()
        {
            return da_db.delete(form_doibong.txt_madb.Text);
        }
    }
}
