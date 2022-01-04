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
    public partial class KhoaThiMain : Form
    {
        KhoaThi khoathiBIZ = new KhoaThi();
        public KhoaThiMain()
        {
            InitializeComponent();
        }

        private void KhoaThiMain_Load(object sender, EventArgs e)
        {
            dgvDanhSachKT.AutoGenerateColumns = false;
            khoathiBIZ.getDSKhoaThi();
            dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
            dgvDanhSachKT.Columns["MaKhoaThi"].DataPropertyName = "MaKhoaThi";
            dgvDanhSachKT.Columns["TenKhoaThi"].DataPropertyName = "TenKhoaThi";
            dgvDanhSachKT.Columns["NgayThi"].DataPropertyName = "NgayThi";
            dgvDanhSachKT.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDanhSachKT.Columns["TrangThai"].DataPropertyName = "TrangThai";

            kiemtrakhoathi();
           

        }
        private void kiemtrakhoathi()
        {
            int maxMonth = Int32.Parse(khoathiBIZ.getNgayCuoi().Month.ToString());
            int currentmonth = Int32.Parse(DateTime.Now.Month.ToString());

            string trangthai = khoathiBIZ.getTrangThaiCuoi();

            if (maxMonth == currentmonth)
            {
                btnThem.Visible = false;
            }
            if (trangthai.Equals("đã kết thúc") && maxMonth < currentmonth)
            {
                btnThem.Visible = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int currentmonth = Int32.Parse(DateTime.Now.Month.ToString());
            int month = Int32.Parse(dtpNgayThi.Value.Month.ToString());

            int currenyear = Int32.Parse(DateTime.Now.Year.ToString());
            int year = Int32.Parse(dtpNgayThi.Value.Year.ToString());

            int maxMonth = Int32.Parse(khoathiBIZ.getNgayCuoi().Month.ToString());

            if (txtTenKhoaThi.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn ngày thi để tên được đặc tự động ", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                if(year > currenyear)
                {
                    if(month > maxMonth)
                    {
                        KhoaThi khoaThi = new KhoaThi();
                        khoaThi.TenKhoaThi = txtTenKhoaThi.Text;
                        khoaThi.NgayThi = dtpNgayThi.Value;
                        khoaThi.TrangThai = "chưa thi";
                        khoathiBIZ.themKhoaThi(khoaThi);
                        dgvDanhSachKT.DataSource = null;
                        dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
                        MessageBox.Show("Thêm khóa thi thành công ", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Đã có khóa thi tồn tại trong tháng này ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (year == currenyear)
                    {
                        if (month >= currentmonth)
                        {
                            if (month > maxMonth)
                            {
                                KhoaThi khoaThi = new KhoaThi();
                                khoaThi.TenKhoaThi = txtTenKhoaThi.Text;
                                khoaThi.NgayThi = dtpNgayThi.Value;
                                khoaThi.TrangThai = "chưa thi";
                                khoathiBIZ.themKhoaThi(khoaThi);
                                dgvDanhSachKT.DataSource = null;
                                dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
                                MessageBox.Show("Thêm khóa thi thành công ", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Đã có khóa thi tồn tại trong tháng này ", "Cảnh báo", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Khóa thi phải lớn hơn hoặc bằng tháng hiện tại ", "Cảnh báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khóa thi phải lớn hơn hoặc bằng tháng hiện tại ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void dtpNgayThi_ValueChanged(object sender, EventArgs e)
        {
            string month = dtpNgayThi.Value.Month.ToString();
            string year = dtpNgayThi.Value.Year.ToString();
            txtTenKhoaThi.Text = "Khóa thi tiếng anh tháng " + month + " năm " + year; 
        }

        private void btnKTKhoaThi_Click(object sender, EventArgs e)
        {
            string trangthai;

            int currentday = Int32.Parse(DateTime.Now.Day.ToString());

            if (this.dgvDanhSachKT.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvDanhSachKT.SelectedRows[0];
                trangthai = row.Cells["TrangThai"].Value.ToString();
                txtTenKhoaThi.Text = row.Cells["TenKhoaThi"].Value.ToString();
                dtpNgayThi.Text = row.Cells["NgayThi"].Value.ToString();
                int day = Int32.Parse(dtpNgayThi.Value.Day.ToString());
                if (trangthai.Equals("chưa thi"))
                {
                    if(currentday > day)
                    {
                        KhoaThi khoathi = new KhoaThi();
                        khoathi.MaKhoaThi = Int32.Parse(row.Cells["MaKhoaThi"].Value.ToString());
                        khoathi.TenKhoaThi = row.Cells["TenKhoaThi"].Value.ToString();
                        khoathi.NgayThi = dtpNgayThi.Value;
                        khoathi.TrangThai = "đã kết thúc";
                        khoathiBIZ.suaKhoaThi(khoathi);
                        kiemtrakhoathi();
                        dgvDanhSachKT.DataSource = null;
                        dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
                        MessageBox.Show("Update trạng thái thành công ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Khóa thi phải diễn ra trong 1 ngày ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể cập nhập trạng thái khóa thi ", "Cảnh báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Chọn một khóa thi để kết thúc khóa thi ", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void dgvDanhSachKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDanhSachKT.Rows[e.RowIndex];
                txtTenKhoaThi.Text = row.Cells["TenKhoaThi"].Value.ToString();
                dtpNgayThi.Text = row.Cells["NgayThi"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.dgvDanhSachKT.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvDanhSachKT.SelectedRows[0];


                int month = Int32.Parse(dtpNgayThi.Value.Month.ToString());

                string dbdaymonth = (row.Cells["NgayThi"].Value.ToString()).Remove(5);

                string[] strS = dbdaymonth.Split('/');
                int dbmonth=0;
                for (int i=0;i<strS.Length;i++)
                {
                    dbmonth = Int32.Parse(strS[1]);
                }

                string trangthai = row.Cells["TrangThai"].Value.ToString();
                if (trangthai.Equals("chưa thi"))
                    {
                    if (dbmonth == month)
                    {
                        //DateTime ngaythi = Convert.ToDateTime(datet);
                        KhoaThi khoathi = new KhoaThi();
                        khoathi.MaKhoaThi = Int32.Parse(row.Cells["MaKhoaThi"].Value.ToString());
                        khoathi.TenKhoaThi = txtTenKhoaThi.Text;
                        khoathi.NgayThi = dtpNgayThi.Value;
                        khoathi.TrangThai = row.Cells["TrangThai"].Value.ToString();
                        khoathiBIZ.suaKhoaThi(khoathi);
                        kiemtrakhoathi();
                        dgvDanhSachKT.DataSource = null;
                        dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
                        MessageBox.Show("Sửa thành công ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không được sửa tháng ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể sửa khóa thi đã kết thúc ", "Cảnh báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                 MessageBox.Show("Chọn một khóa thi để sửa ", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.dgvDanhSachKT.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvDanhSachKT.SelectedRows[0];
                string trangthai = row.Cells["TrangThai"].Value.ToString();
                if(trangthai.Equals("đã kết thúc"))
                {
                    MessageBox.Show("Không thể xóa khóa thi đã kết thúc ", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    KhoaThi khoathi = new KhoaThi();
                    khoathi.MaKhoaThi = Int32.Parse(row.Cells["MaKhoaThi"].Value.ToString());
                    khoathiBIZ.xoaKhoaThi(khoathi);
                    dgvDanhSachKT.DataSource = null;
                    dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
                    MessageBox.Show("Xóa thành công ", "Cảnh báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Chọn một khóa thi để xóa ", "Cảnh báo", MessageBoxButtons.OK);
            }
        }
    }
}
