using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDoiBong.BUS;

namespace QuanLyDoiBong.GUI
{
    public partial class Frm_HuanLuyenVien : Form
    {
        BUS_HuanLuyenVien bus_HLV;
        public Frm_HuanLuyenVien()
        {
            InitializeComponent();
            bus_HLV = new BUS_HuanLuyenVien(this);
        }

        private void Frm_HuanLuyenVien_Load(object sender, EventArgs e)
        {
            bus_HLV.setComboDoiBong();
            bus_HLV.setDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bus_HLV.insert() > 0)
            {
                bus_HLV.setDataGrid();
                MessageBox.Show("Thanh công");
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bus_HLV.delete() > 0)
            {
                bus_HLV.setDataGrid();
                MessageBox.Show("Thanh công");
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bus_HLV.update() > 0)
            {
                bus_HLV.setDataGrid();
                MessageBox.Show("Thanh công");
            }
            else
                MessageBox.Show("Thất bại");
        }
    }
}
