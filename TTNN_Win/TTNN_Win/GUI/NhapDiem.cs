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
using TTNN_Win.DAL;
using TTNN_Win.DTO;

namespace TTNN_Win.GUI
{
    public partial class NhapDiem : Form
    {
        DAL_NhapDiem dao = new DAL_NhapDiem();
        BIZ_NhapDiem bus = new BIZ_NhapDiem();
        List<ThiSinhTheoPhongThi> lstTSPT = new List<ThiSinhTheoPhongThi>();
        List<KhoaThi> lstKhoaThi = new List<KhoaThi>();
        List<PhongThi> lstPhongThi = new List<PhongThi>();
        List<String> lstTenThiSinh = new List<string>();
        List<DTOThiSinh> lstThiSinh = new List<DTOThiSinh>();
        //int SelectedIndex = 0;

        public NhapDiem()
        {
            InitializeComponent();
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            dgvTS.AutoGenerateColumns = false;
            
            
            dgvTS.DataSource = lstThiSinh;
            dgvTS.Columns["MaThiSinh"].DataPropertyName = "MaThiSinh";
            dgvTS.Columns["MaPhongThi"].DataPropertyName = "MaPhongThi";
            dgvTS.Columns["SBD"].DataPropertyName = "SBD";
            dgvTS.Columns["TenThiSinh"].DataPropertyName = "Ten";
            dgvTS.Columns["DiemNghe"].DataPropertyName = "DiemNghe";
            dgvTS.Columns["DiemNoi"].DataPropertyName = "DiemNoi";
            dgvTS.Columns["DiemDoc"].DataPropertyName = "DiemDoc";
            dgvTS.Columns["DiemViet"].DataPropertyName = "DiemViet";
            //bus.getDanhSachKhoaThi();

            lstKhoaThi = bus.getDanhSachKT();

            foreach (var item in lstKhoaThi)
            {
                cbKhoa.Items.Add(item.TenKhoaThi);
            }
            
            
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPhongThi = bus.getDanhSachPhongThi(lstKhoaThi[cbKhoa.SelectedIndex].MaKhoaThi);
            foreach (var item in lstPhongThi)
            {
                cbPhong.Items.Add(item.TenPhongThi);
            }
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bus.getDanhSachTSTheoPhong(BIZ_NhapDiem.dsPT[cbPhong.SelectedIndex].MaPhongThi);
            //lstTSPT = bus.getThiSinh(lstPhongThi[cbPhong.SelectedIndex].MaPhongThi);
            lstThiSinh = bus.getListAllInfoTS(lstPhongThi[cbPhong.SelectedIndex].MaPhongThi);
            dgvTS.DataSource = null;
            dgvTS.DataSource = lstThiSinh;
            cbPhong.Items.Clear();
            foreach (var p in lstPhongThi)
            {
                cbPhong.Items.Add(p.TenPhongThi);
            }


        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {

            
            if (bus.capNhapThiSinh(lstTSPT))
            {
                MessageBox.Show("Cập nhập điểm thi thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cập nhập điểm thi thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
