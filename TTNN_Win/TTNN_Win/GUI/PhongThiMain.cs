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
    public partial class PhongThiMain : Form
    {
        PhongThi phongthibiz = new PhongThi();
        public PhongThiMain()
        {
            InitializeComponent();
            if(phongthibiz.getTrangThaiCuoi().Equals("chưa thi"))
            {
                MessageBox.Show("Đang có 1 khóa thi đang hoạt động trong tháng ", "Thông báo", MessageBoxButtons.OK);
                txtTenKhoaThi.Text = phongthibiz.getNameById(phongthibiz.getMaKhoaThiCuoi());
            }
            else
            {             
                MessageBox.Show("Không có khóa thi đang hoạt động trong tháng ", "Thông báo", MessageBoxButtons.OK);
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                txtSoTT.Enabled = false;
                txtSoLuong.Enabled = false;
            }
            cbxTrinhDo.SelectedIndex = 0;
            
        }
        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenKhoaThi.Text.Equals("") || txtSoLuong.Text.Equals("") || txtSoTT.Equals("") || cbxTrinhDo.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống ", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                if (IsAllDigits(txtSoTT.Text) && IsAllDigits(txtSoLuong.Text))
                {
                    if(Int32.Parse(txtSoLuong.Text) > 35 || Int32.Parse(txtSoLuong.Text) < 30)
                    {
                        MessageBox.Show("Số lượng thí sinh phải >= 30 và <= 35 ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        
                        PhongThi phongthi = new PhongThi();
                        phongthi.TenPhongThi = txtTenPhongThi.Text;
                        phongthi.TrinhDo = cbxTrinhDo.SelectedItem.ToString();
                        phongthi.SoLuongThiSinh = Int32.Parse(txtSoLuong.Text);
                        phongthi.MaKhoaThi = phongthibiz.getMaKhoaThiCuoi();
                        phongthibiz.themPhongThi(phongthi);
                        dgvDanhSachPT.DataSource = null;
                        dgvDanhSachPT.DataSource = PhongThi.listPhongThi;
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Số thứ tự và số lượng thí sinh không được chứa ký tự ", "Cảnh báo", MessageBoxButtons.OK);
                }
            }
        }

        private void PhongThiMain_Load(object sender, EventArgs e)
        {
            dgvDanhSachPT.AutoGenerateColumns = false;
            phongthibiz.getDSPhongThi();
            dgvDanhSachPT.DataSource = PhongThi.listPhongThi;
            dgvDanhSachPT.Columns["MaPhongThi"].DataPropertyName = "MaPhongThi";
            dgvDanhSachPT.Columns["TenPhongThi"].DataPropertyName = "TenPhongThi";
            dgvDanhSachPT.Columns["TrinhDo"].DataPropertyName = "TrinhDo";
            dgvDanhSachPT.Columns["SoLuongThiSinh"].DataPropertyName = "SoLuongThiSinh";
            dgvDanhSachPT.Columns["MaKhoaThi"].DataPropertyName = "MaKhoaThi";

        }

        private void dgvDanhSachPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDanhSachPT.Rows[e.RowIndex];
                txtTenPhongThi.Text = row.Cells["TenPhongThi"].Value.ToString();
                cbxTrinhDo.Text = row.Cells["TrinhDo"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuongThiSinh"].Value.ToString();
                txtTenKhoaThi.Text = phongthibiz.getNameById(Int32.Parse(row.Cells["MaKhoaThi"].Value.ToString()));
                string ten = row.Cells["TenPhongThi"].Value.ToString();
                string SoTT = "";
                string[] strS = ten.Split('P');
                for(int i=0;i< strS.Length; i++)
                {
                    SoTT = strS[1];
                }
                txtSoTT.Text = SoTT;
            }
        }

        private void cbxTrinhDo_SelectedValueChanged(object sender, EventArgs e)
        {
            string trinhdo,soluong;
            soluong = txtSoTT.Text;
            trinhdo = cbxTrinhDo.SelectedItem.ToString();
            txtTenPhongThi.Text = trinhdo + "P" + soluong;
        }

        private void txtSoTT_TextChanged(object sender, EventArgs e)
        {
            string trinhdo, soluong;
            soluong = txtSoTT.Text;
            trinhdo = cbxTrinhDo.SelectedItem.ToString();
            txtTenPhongThi.Text = trinhdo + "P" + soluong;
        }
    }
}
