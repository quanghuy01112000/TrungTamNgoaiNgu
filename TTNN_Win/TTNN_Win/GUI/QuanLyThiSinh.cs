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

namespace TTNN_Win.GUI
{
    public partial class QuanLyThiSinh : Form
    {
        DAO_QuanLyThiSinh daoThiSinh = new DAO_QuanLyThiSinh();
        KhoaThiDAL daoKhoaThi = new KhoaThiDAL();
        ThiSinh busThiSinh = new ThiSinh();
        List<ThiSinh> listSearchThiSinh = new List<ThiSinh>();
        int SelectedIndexThiSinh = 0;

        public QuanLyThiSinh()
        {
            
            InitializeComponent();


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

        private void QuanLyThiSinh_Load(object sender, EventArgs e)
        {
            dgvQuanLyDanhSachTS.AutoGenerateColumns = false;
            busThiSinh.getDanhSachThiSinh();
            dgvQuanLyDanhSachTS.DataSource = ThiSinh.listThiSinh;
            dgvQuanLyDanhSachTS.Columns["MaThiSinh"].DataPropertyName = "MaThiSinh";
            dgvQuanLyDanhSachTS.Columns["TenThiSinh"].DataPropertyName = "TenThiSinh";
            dgvQuanLyDanhSachTS.Columns["NgaySinh"].DataPropertyName = "NgaySinh";
            dgvQuanLyDanhSachTS.Columns["GioiTinh"].DataPropertyName = "GioiTinh";
            dgvQuanLyDanhSachTS.Columns["CMND"].DataPropertyName = "CMND";
            dgvQuanLyDanhSachTS.Columns["SoDienThoai"].DataPropertyName = "SoDienThoai";
            dgvQuanLyDanhSachTS.AllowUserToOrderColumns = true;

            if (busThiSinh.getKhoaThiByTrangThai().TrangThai == null )
            {
                this.buttonThem.Enabled = false;
            }

            comboBoxGioiTinh.DataSource = ThiSinh.listGioiTinh;
        }
        
        private void dgvQuanLyDanhSachTS_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndexThiSinh = dgvQuanLyDanhSachTS.CurrentCell.RowIndex;
            ThiSinh thiSinh = null;
            try
            {
                thiSinh = dgvQuanLyDanhSachTS.CurrentRow.DataBoundItem as ThiSinh;
                textBoxMaThiSinh.Text = thiSinh.MaThiSinh.ToString();
                textBoxTenThiSinh.Text = thiSinh.TenThiSinh.ToString();
                dateTimePickerNgaySinh.Value = thiSinh.NgaySinh.Value;
                comboBoxGioiTinh.Text = thiSinh.GioiTinh;
                textBoxCMND.Text = thiSinh.Cmnd.ToString();
                textBoxSDT.Text = thiSinh.SoDienThoai.ToString();
            } catch(IndexOutOfRangeException ex) { Console.WriteLine(ex); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTenThiSinh.Text == "" || dateTimePickerNgaySinh.Value == null
                || comboBoxGioiTinh.Text == null || textBoxCMND.Text == "" || textBoxSDT.Text == ""
                || IsAllDigits(textBoxCMND.Text) == false || IsAllDigits(textBoxSDT.Text) == false)

            {
                MessageBox.Show("Nhập vào sai!", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                ThiSinh thiSinh = dgvQuanLyDanhSachTS.CurrentRow.DataBoundItem as ThiSinh;
                thiSinh.TenThiSinh = textBoxTenThiSinh.Text;
                thiSinh.NgaySinh = dateTimePickerNgaySinh.Value.Date;
                thiSinh.GioiTinh = comboBoxGioiTinh.Text;
                thiSinh.Cmnd = textBoxCMND.Text;
                thiSinh.SoDienThoai = textBoxSDT.Text;
                dgvQuanLyDanhSachTS.Update();
                dgvQuanLyDanhSachTS.Refresh();
                busThiSinh.suaThisinh(thiSinh);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            var messageXoa = MessageBox.Show("Bạn có muốn xoá thí sinh này không?", "Bạn đang xoá thí sinh", MessageBoxButtons.YesNo);
            if (messageXoa == DialogResult.Yes)
            {
                ThiSinh thiSinh = dgvQuanLyDanhSachTS.CurrentRow.DataBoundItem as ThiSinh;
                if (busThiSinh.xoaThiSinh(thiSinh))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvQuanLyDanhSachTS.DataSource = null;
                    dgvQuanLyDanhSachTS.DataSource = ThiSinh.listThiSinh;
                }
                else
                {
                    MessageBox.Show("Không thể xoá!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Hủy xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            String textSearch = textBoxSearch.Text.ToLower();
            listSearchThiSinh = busThiSinh.timKiemThiSinh(textSearch);
            if(textBoxSearch.Text == "")
            {
                dgvQuanLyDanhSachTS.DataSource = ThiSinh.listThiSinh;
            }
            else
            {
                dgvQuanLyDanhSachTS.DataSource = listSearchThiSinh;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ThemThiSinh themThiSinh = new ThemThiSinh();
            themThiSinh.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvQuanLyDanhSachTS.DataSource = null;
            dgvQuanLyDanhSachTS.DataSource = ThiSinh.listThiSinh;
        }
    }
}
