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
    public partial class ThemThiSinh : Form
    {
        DAO_QuanLyThiSinh daoThiSinh = new DAO_QuanLyThiSinh();
        ThiSinh busThiSinh = new ThiSinh();
        public ThemThiSinh()
        {
            InitializeComponent();
            comboBoxGioiTinh.SelectedIndex = 0;
            comboBoxTrinhDo.SelectedIndex = 0;
        }
        private void ThemThiSinh_Load(object sender, EventArgs e)
        {
            comboBoxTrinhDo.DataSource = ThiSinh.listTrinhDo;
            comboBoxGioiTinh.DataSource = ThiSinh.listGioiTinh;
        }

        private void buttonThemThiSinh_Click(object sender, EventArgs e)
        {
            if (textBoxTenThiSinh.Text == "" || dateTimePickerNgaySinh.Value == null
                || comboBoxGioiTinh.Text == null || textBoxCMND.Text == "" || textBoxSDT.Text == "" || comboBoxTrinhDo.Text == null)
            {
                MessageBox.Show("Nhập vào sai!", "Cảnh báo", MessageBoxButtons.OK);
            }
            ThiSinh thiSinh = new ThiSinh();
            thiSinh.TenThiSinh = textBoxTenThiSinh.Text;
            thiSinh.NgaySinh = dateTimePickerNgaySinh.Value.Date;
            thiSinh.GioiTinh = comboBoxGioiTinh.Text;
            thiSinh.Cmnd = textBoxCMND.Text;
            thiSinh.SoDienThoai = textBoxSDT.Text;

            ThiSinhCuaKhoaThi thiSinhCuaKhoaThi = new ThiSinhCuaKhoaThi();
            thiSinhCuaKhoaThi.MaThiSinh = busThiSinh.getMaThiSinhMax() +1;
            thiSinhCuaKhoaThi.MaKhoaThi = busThiSinh.getKhoaThiByTrangThai().MaKhoaThi;
            thiSinhCuaKhoaThi.TrinhDo = comboBoxTrinhDo.Text;
            
            if(busThiSinh.themThiSinh(thiSinh) && busThiSinh.themThiSinhCuaKhoathi(thiSinhCuaKhoaThi))
            {
                this.Close();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
