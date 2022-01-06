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
        private List<PhongThi> lstPT = new List<PhongThi>();

        DateTime ngayThi;
        int selectedRow =0 ;
        int maPT = 1;
        int maKT = 1;
        DSTS_BUS bus = new DSTS_BUS();
        public DSTS()
        {
            InitializeComponent();
            load();
            getNgayThi();
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
            loadListPT(); 
            foreach (PhongThi i in lstPT)
            {
                cbxPhongThi.Items.Add(i.TenPhongThi);
            }
            cbxKhoaThi.SelectedIndex = 0;
            cbxPhongThi.SelectedIndex = 0;
            var table = from i in DSTS_BUS.dsTSPT
                        where i.MaPhongThi == maPT
                        select i;
            dgvTS.DataSource = table.ToList();


        }

        private void loadListPT()
        {
            lstPT = new List<PhongThi>();
            cbxPhongThi.Items.Clear();
            foreach(PhongThi p in DSTS_BUS.dsPT) {
                if (p.MaKhoaThi == maKT)
                {
                    lstPT.Add(p);
                    cbxPhongThi.Items.Add(p.TenPhongThi);
                }
            }
            
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            getTS();
            ChiTIetTS t = new ChiTIetTS(getTS(),getTSPT(),ngayThi);
            t.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void cbxPhongThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            maPT = getMaPT(cbxPhongThi.SelectedIndex);

            reload();
        }

        private void reload()
        {
            
            dgvTS.DataSource = null;
            var table = from i in DSTS_BUS.dsTSPT
                        where i.MaPhongThi == maPT
                        select i;
            dgvTS.DataSource = table.ToList();

        }

        private void cbxKhoaThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            maKT = cbxKhoaThi.SelectedIndex + 1;
            loadListPT();
            maPT = getMaPT(0);
            reload();
            getNgayThi();
        }

        private int getMaPT(int index)
        {
            return lstPT[index].MaPhongThi;
        }

        private ThiSinh getTS (){
            ThiSinh tmp = new ThiSinh();
            DataGridViewRow row = dgvTS.Rows[selectedRow]; 
            int maTS = (int)row.Cells[0].Value;
            //Console.WriteLine(maTS);
            foreach(ThiSinh i in DSTS_BUS.dsTS)
            {
                if(i.MaThiSinh == maTS)
                {
                    tmp = i;
                    break;
                }
            }
            return tmp;
        }

        private ThiSinhTheoPhongThi getTSPT() { 
            ThiSinhTheoPhongThi tmp = new ThiSinhTheoPhongThi();
            DataGridViewRow row = dgvTS.Rows[selectedRow];
            int maTS = (int)row.Cells[0].Value;
            //Console.WriteLine(maTS);
            foreach (ThiSinhTheoPhongThi i in DSTS_BUS.dsTSPT ){
                {
                    if (i.MaThiSinh == maTS)
                    {
                        tmp = i;
                        break;
                    }
                } 
            }
            return tmp;
        }

        private void getNgayThi()
        {
            foreach(KhoaThi i in DSTS_BUS.dsKT)
            {
                if(i.MaKhoaThi == maKT)
                {
                    ngayThi = (DateTime)i.NgayThi;
                }
            }
        }



        private void dgvTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            maKT = 1;
            maPT = 1;
            load();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            String txt  = txtTimKiem.Text;
            var table = from i in DSTS_BUS.dsTSPT
                        where i.SBD.Contains(txt) || i.MaThiSinh.ToString().Contains(txt) || i.MaPhongThi.ToString().Contains(txt)
                                                  || i.DiemDoc.ToString().Contains(txt) || i.DiemViet.ToString().Contains(txt) || i.DiemNoi.ToString().Contains(txt) || i.DiemViet.ToString().Contains(txt)
                        select i;

            dgvTS.DataSource = null;
            dgvTS.DataSource = table.ToList();
        }
    }
}
