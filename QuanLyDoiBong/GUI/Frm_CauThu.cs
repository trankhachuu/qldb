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
    public partial class Frm_CauThu : Form
    {
        BUS_CauThu bus_CT;
        public Frm_CauThu()
        {
            InitializeComponent();
            bus_CT = new BUS_CauThu(this);
        }

        private void Frm_CauThu_Load(object sender, EventArgs e)
        {
            bus_CT.setComboDoiBong();
            bus_CT.setDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bus_CT.insert() > 0){
                bus_CT.setDataGrid();
                MessageBox.Show("Thanh công");
            }
               
            else
                MessageBox.Show("Thất bại");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bus_CT.delete() > 0)
            {
                bus_CT.setDataGrid();
                MessageBox.Show("Thanh công");
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bus_CT.update() > 0)
            {
                bus_CT.setDataGrid();
                MessageBox.Show("Thanh công");
            }
            else
                MessageBox.Show("Thất bại");
        }
    }
}
