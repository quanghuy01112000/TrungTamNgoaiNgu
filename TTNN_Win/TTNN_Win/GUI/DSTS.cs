using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNN_Win.BIZ;

namespace TTNN_Win.GUI
{
    public partial class DSTS : Form
    {
        
        int maPT = 1;
        int maKT = 1;
        DSTS_BUS bus = new DSTS_BUS();
        public DSTS()
        {
            InitializeComponent();
            load();
        }

        public DSTS(String maPhongThi)
        {

        }

        private void DSTS_Load(object sender, EventArgs e)
        {

        }

        private void load()
        {
            //dgvTS.DataSource = DSTS_BUS.dsTSPT;
            foreach (KhoaThi i in DSTS_BUS.dsKT)
            {
                cbxKhoaThi.Items.Add(i.MaKhoaThi);
            }

            foreach (PhongThi i in DSTS_BUS.dsPT)
            {
                if (i.MaKhoaThi == maKT)
                    cbxPhongThi.Items.Add(i.TenPhongThi);
            }
            cbxKhoaThi.SelectedIndex = 0;
            cbxPhongThi.SelectedIndex = 0;
            var table = from i in DSTS_BUS.dsTSPT
                        where i.MaPhongThi == maPT
                        select i;
            dgvTS.DataSource = table.ToList();


        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ChiTIetTS t = new ChiTIetTS();
            t.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void dgvTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxPhongThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            maPT = (from i in DSTS_BUS.dsPT
                    where i.MaKhoaThi == maKT
                    select i.MaPhongThi).FirstOrDefault();
            dgvTS.DataSource = null;
            var table = from i in DSTS_BUS.dsTSPT
                        where i.MaPhongThi == maPT
                        select i;
            dgvTS.DataSource = table.ToList();

        }

        private void cbxKhoaThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            maKT = cbxKhoaThi.SelectedIndex + 1;
            
            reload();
        }

        private void refr (){
                
        }

    }
}
