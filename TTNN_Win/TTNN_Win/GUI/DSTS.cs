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
        int selectedRow = 0;
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
            busPhongThi.getDSPhongThi();
            int maKhoaThi = busThiSinh.getKhoaThiByTrangThai().MaKhoaThi;
            if (PhongThi.listPhongThi.Where(p => p.MaKhoaThi == maKhoaThi).Count() > 0)
            {
                buttonXepPhongThi.Enabled = false;
            }
            if (busThiSinh.getKhoaThiByTrangThai().TrangThai == null)
            {
                buttonXepPhongThi.Enabled = false;
            }
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

        

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            getTS();
            ChiTIetTS t = new ChiTIetTS(getTS(), getTSPT(), ngayThi);
            t.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        

        private void reload()
        {

            dgvTS.DataSource = null;
            var table = from i in DSTS_BUS.dsTSPT
                        where i.MaPhongThi == maPT
                        select i;
            dgvTS.DataSource = table.ToList();

        }
        private void loadListPT()
        {
            lstPT = new List<PhongThi>();
            cbxPhongThi.Items.Clear();
            foreach (PhongThi p in DSTS_BUS.dsPT)
            {
                if (p.MaKhoaThi == maKT)
                {
                    lstPT.Add(p);
                    cbxPhongThi.Items.Add(p.TenPhongThi);
                }
            }


        }
        private void cbxPhongThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            maPT = getMaPT(cbxPhongThi.Text);

            reload();
        }
        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return !list.Any();
        }
        private void cbxKhoaThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            maKT = cbxKhoaThi.SelectedIndex + 1;
            loadListPT();
            if (IsEmpty(lstPT))
            {
                MessageBox.Show("Chưa có phòng thi cho khóa thi này");
                maKT--;
            }
            else
            {
                maPT = getMaPT(cbxPhongThi.Text);
                reload();
                getNgayThi();
            }
        }

        private int getMaPT(String text)
        {
            foreach (PhongThi i in lstPT)
            {
                if (i.TenPhongThi.Equals(text))
                {
                    return i.MaPhongThi;
                }
            }
            return maPT;
        }

        private ThiSinh getTS()
        {
            ThiSinh tmp = new ThiSinh();
            DataGridViewRow row = dgvTS.Rows[selectedRow];
            int maTS = (int)row.Cells[0].Value;
            //Console.WriteLine(maTS);
            foreach (ThiSinh i in DSTS_BUS.dsTS)
            {
                if (i.MaThiSinh == maTS)
                {
                    tmp = i;
                    break;
                }
            }
            return tmp;
        }

        private ThiSinhTheoPhongThi getTSPT()
        {
            ThiSinhTheoPhongThi tmp = new ThiSinhTheoPhongThi();
            DataGridViewRow row = dgvTS.Rows[selectedRow];
            int maTS = (int)row.Cells[0].Value;
            //Console.WriteLine(maTS);
            foreach (ThiSinhTheoPhongThi i in DSTS_BUS.dsTSPT)
            {
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
            foreach (KhoaThi i in DSTS_BUS.dsKT)
            {
                if (i.MaKhoaThi == maKT)
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
            String txt = txtTimKiem.Text;
            var table = from i in DSTS_BUS.dsTSPT
                        where i.SBD.Contains(txt) || i.MaThiSinh.ToString().Contains(txt) || i.MaPhongThi.ToString().Contains(txt)
                                                  || i.DiemDoc.ToString().Contains(txt) || i.DiemViet.ToString().Contains(txt) || i.DiemNoi.ToString().Contains(txt) || i.DiemViet.ToString().Contains(txt)
                        select i;

            dgvTS.DataSource = null;
            dgvTS.DataSource = table.ToList();
        }

        ThiSinh busThiSinh = new ThiSinh();
        ThiSinhCuaKhoaThi busThiSinhCuaKhoaThi = new ThiSinhCuaKhoaThi();
        PhongThi busPhongThi = new PhongThi();
        private void buttonXepPhongThi_Click(object sender, EventArgs e)
        {
            int maKhoaThi = busThiSinh.getKhoaThiByTrangThai().MaKhoaThi;
            int soLuongThiSinhCuaA2 = busPhongThi.getSoLuongThiSinhA2();
            List<Int32> listThiSinhTheoTrinhDoA2 = busThiSinh.getMaThiSinhByTrinhDoA2();
            int countTenPhongThiA2 = 1;
            int countSBDA2 = 1;
            int countListThiSinhA2 = 0;
            while (soLuongThiSinhCuaA2 >= 30)
            {
                PhongThi phongThiA2 = new PhongThi();
                phongThiA2.TenPhongThi = "A2P" + countTenPhongThiA2.ToString("D2");
                phongThiA2.TrinhDo = "A2";
                if (soLuongThiSinhCuaA2 >= 35)
                {
                    phongThiA2.SoLuongThiSinh = 35;
                }
                else if (30 <= soLuongThiSinhCuaA2 && soLuongThiSinhCuaA2 <= 35)
                {
                    phongThiA2.SoLuongThiSinh = soLuongThiSinhCuaA2;
                }
                phongThiA2.MaKhoaThi = maKhoaThi;
                busPhongThi.taoPhongThiTuDong(phongThiA2);
                soLuongThiSinhCuaA2 = soLuongThiSinhCuaA2 - 35;
                countTenPhongThiA2++;

                for (int i = 0; i < phongThiA2.SoLuongThiSinh; i++)
                {
                    ThiSinhTheoPhongThi thiSinhTheoPhongThi = new ThiSinhTheoPhongThi();
                    thiSinhTheoPhongThi.MaThiSinh = listThiSinhTheoTrinhDoA2[countListThiSinhA2];
                    thiSinhTheoPhongThi.MaPhongThi = phongThiA2.MaPhongThi;
                    thiSinhTheoPhongThi.SBD = "A2" + countSBDA2.ToString("D3");
                    busPhongThi.themThiSinhVaoPhongThi(thiSinhTheoPhongThi);
                    countSBDA2++;
                    countListThiSinhA2++;
                }

            }
            int soLuongThiSinhCuaB1 = busPhongThi.getSoLuongThiSinhB1();
            List<Int32> listThiSinhTheoTrinhDoB1 = busThiSinh.getMaThiSinhByTrinhDoB1();
            int countTenPhongThiB1 = 1;
            int countSBDB1 = 1;
            int countListThiSinhB1 = 0;
            while (soLuongThiSinhCuaB1 >= 30)
            {

                PhongThi phongThiB1 = new PhongThi();
                phongThiB1.TenPhongThi = "B1P" + countTenPhongThiB1.ToString("D2");
                phongThiB1.TrinhDo = "B1";
                if (soLuongThiSinhCuaB1 >= 35)
                {
                    phongThiB1.SoLuongThiSinh = 35;
                }
                else if (30 <= soLuongThiSinhCuaB1 && soLuongThiSinhCuaB1 <= 35)
                {
                    phongThiB1.SoLuongThiSinh = soLuongThiSinhCuaB1;
                }
                phongThiB1.MaKhoaThi = maKhoaThi;
                busPhongThi.taoPhongThiTuDong(phongThiB1);
                soLuongThiSinhCuaB1 = soLuongThiSinhCuaB1 - 35;
                countTenPhongThiB1++;

                for (int i = 0; i < phongThiB1.SoLuongThiSinh; i++)
                {
                    ThiSinhTheoPhongThi thiSinhTheoPhongThi = new ThiSinhTheoPhongThi();
                    thiSinhTheoPhongThi.MaThiSinh = listThiSinhTheoTrinhDoB1[countListThiSinhB1];
                    thiSinhTheoPhongThi.MaPhongThi = phongThiB1.MaPhongThi;
                    thiSinhTheoPhongThi.SBD = "B1" + countSBDB1.ToString("D3");
                    busPhongThi.themThiSinhVaoPhongThi(thiSinhTheoPhongThi);
                    countSBDB1++;
                    countListThiSinhB1++;
                }

            }

            buttonXepPhongThi.Enabled = false;
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
