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
            loaddata();
            kiemtrakhoathi();
        }
        public void loaddata()
        {
            dgvDanhSachKT.AutoGenerateColumns = false;
            khoathiBIZ.getDSKhoaThi();
            dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
            dgvDanhSachKT.Columns["MaKhoaThi"].DataPropertyName = "MaKhoaThi";
            dgvDanhSachKT.Columns["TenKhoaThi"].DataPropertyName = "TenKhoaThi";
            dgvDanhSachKT.Columns["NgayThi"].DataPropertyName = "NgayThi";
            dgvDanhSachKT.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDanhSachKT.Columns["TrangThai"].DataPropertyName = "TrangThai";
            dgvDanhSachKT.Columns["PhongA2ToiDa"].DataPropertyName = "PhongA2ToiDa";
            dgvDanhSachKT.Columns["PhongB1ToiDa"].DataPropertyName = "PhongB1ToiDa";
        }
        private void kiemtrakhoathi()
        {
            int maxMonth = Int32.Parse(khoathiBIZ.getNgayCuoi().Month.ToString());
            int currentmonth = Int32.Parse(DateTime.Now.Month.ToString());

            string trangthai = khoathiBIZ.getTrangThaiCuoi();

            if (maxMonth == currentmonth)
            {
                btnThem.Enabled = false;
            }
            if (trangthai.Equals("đã kết thúc"))
            {
                btnThem.Enabled = true;
            }
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
            int monthNow = Int32.Parse(DateTime.Now.Month.ToString());
            int monthDTP = Int32.Parse(dtpNgayThi.Value.Month.ToString());

            int yearNow = Int32.Parse(DateTime.Now.Year.ToString());
            int yearDTP = Int32.Parse(dtpNgayThi.Value.Year.ToString());

            int dayNow = Int32.Parse(DateTime.Now.Day.ToString());
            int dayDTP = Int32.Parse(dtpNgayThi.Value.Day.ToString());

            int maxMonth = Int32.Parse(khoathiBIZ.getNgayCuoi().Month.ToString());
            int maxYear = Int32.Parse(khoathiBIZ.getNgayCuoi().Year.ToString());

            if (txtTenKhoaThi.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn ngày thi để tên được đặc tự động ", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                if(yearDTP > maxYear)
                {
                    if(yearDTP >= yearNow)
                    {
                        if (monthDTP >= monthNow)
                        {
                            if(dayDTP >= dayNow)
                            {
                                if(txtSlA2.Text.Equals("") || txtSlA2.Equals(""))
                                {
                                    MessageBox.Show("Số lượng không được rỗng ", "Cảnh báo", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    if (IsAllDigits(txtSlA2.Text)==false || IsAllDigits(txtSlB1.Text)==false || Int32.Parse(txtSlA2.Text) < 0 || Int32.Parse(txtSlB1.Text) < 0)
                                    {
                                        MessageBox.Show("Số lượng phòng không được chứa chữ và lớn hơn 0 ", "Cảnh báo", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        KhoaThi khoaThi = new KhoaThi();
                                        khoaThi.TenKhoaThi = txtTenKhoaThi.Text;
                                        khoaThi.NgayThi = dtpNgayThi.Value;
                                        khoaThi.TrangThai = "chưa thi";
                                        khoaThi.PhongA2ToiDa = Int32.Parse(txtSlA2.Text);
                                        khoaThi.PhongB1ToiDa = Int32.Parse(txtSlB1.Text);
                                        khoathiBIZ.themKhoaThi(khoaThi);
                                        dgvDanhSachKT.DataSource = null;
                                        dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
                                        kiemtrakhoathi();
                                        MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ngày của khóa thi phải lớn hơn hoặc bằng ngày hiện tại ", "Cảnh báo", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tháng của khóa thi phải lớn hơn hoặc bằng tháng hiện tại ", "Cảnh báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Năm của khóa thi phải lớn hơn hoặc bằng năm hiện tại ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (yearDTP == maxYear)
                    {
                        if(yearDTP >= yearNow)
                        {
                            if (monthDTP >= monthNow)
                            {
                                if (monthDTP > maxMonth)
                                {
                                    if (dayDTP >= dayNow)
                                    {
                                        if (txtSlA2.Text.Equals("") || txtSlA2.Equals(""))
                                        {
                                            MessageBox.Show("Số lượng không được rỗng ", "Cảnh báo", MessageBoxButtons.OK);
                                        }
                                        else
                                        {
                                            if (IsAllDigits(txtSlA2.Text)==false || IsAllDigits(txtSlB1.Text)==false || Int32.Parse(txtSlA2.Text) < 0 || Int32.Parse(txtSlB1.Text) < 0)
                                            {
                                                MessageBox.Show("Số lượng phòng không được chứa chữ và lớn hơn 0 ", "Cảnh báo", MessageBoxButtons.OK);
                                            }
                                            else
                                            {
                                                KhoaThi khoaThi = new KhoaThi();
                                                khoaThi.TenKhoaThi = txtTenKhoaThi.Text;
                                                khoaThi.NgayThi = dtpNgayThi.Value;
                                                khoaThi.TrangThai = "chưa thi";
                                                khoaThi.PhongA2ToiDa = Int32.Parse(txtSlA2.Text);
                                                khoaThi.PhongB1ToiDa = Int32.Parse(txtSlB1.Text);
                                                khoathiBIZ.themKhoaThi(khoaThi);
                                                dgvDanhSachKT.DataSource = null;
                                                dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
                                                kiemtrakhoathi();
                                                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ngày của khóa thi phải lớn hơn hoặc bằng ngày hiện tại ", "Cảnh báo", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Đã có khóa thi tồn tại trong tháng này " + khoathiBIZ.getNgayCuoi().Month.ToString(), "Cảnh báo", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tháng khóa thi phải lớn hơn hoặc bằng tháng hiện tại ", "Cảnh báo", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Năm của khóa thi phải lớn hơn hoặc bằng năm hiện tại ", "Cảnh báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Năm của khóa thi phải lớn hơn hoặc bằng khóa thi trước ", "Cảnh báo", MessageBoxButtons.OK);
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
                        KhoaThi khoathi = dgvDanhSachKT.CurrentRow.DataBoundItem as KhoaThi; 
                        khoathi.MaKhoaThi = Int32.Parse(row.Cells["MaKhoaThi"].Value.ToString());
                        khoathi.TenKhoaThi = row.Cells["TenKhoaThi"].Value.ToString();
                        khoathi.NgayThi = dtpNgayThi.Value;
                        khoathi.TrangThai = "đã kết thúc";
                        khoathiBIZ.suaTrangThaiKhoaThi(khoathi);
                        kiemtrakhoathi();
                        dgvDanhSachKT.Refresh();
                        dgvDanhSachKT.Update();
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
                        KhoaThi khoathi = dgvDanhSachKT.CurrentRow.DataBoundItem as KhoaThi;
                        khoathi.MaKhoaThi = Int32.Parse(row.Cells["MaKhoaThi"].Value.ToString());
                        khoathi.TenKhoaThi = txtTenKhoaThi.Text;
                        khoathi.NgayThi = dtpNgayThi.Value;
                        khoathi.TrangThai = row.Cells["TrangThai"].Value.ToString();
                        if (khoathiBIZ.suaKhoaThi(khoathi))
                        {
                            kiemtrakhoathi();
                            dgvDanhSachKT.Refresh();
                            dgvDanhSachKT.Update();
                            MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại vì có thi sinh đăng ký khóa thi ", "Cảnh báo", MessageBoxButtons.OK);
                        }
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
                    KhoaThi khoathi = dgvDanhSachKT.CurrentRow.DataBoundItem as KhoaThi;
                    khoathi.MaKhoaThi = Int32.Parse(row.Cells["MaKhoaThi"].Value.ToString());
                    if (khoathiBIZ.xoaKhoaThi(khoathi))
                    {
                        dgvDanhSachKT.DataSource = null;
                        dgvDanhSachKT.DataSource = KhoaThi.listKhoaThi;
                        kiemtrakhoathi();
                        MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại do có thí sinh đăng ký khóa thi này ", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn một khóa thi để xóa ", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void btnSuaSoLuong_Click(object sender, EventArgs e)
        {

            if (this.dgvDanhSachKT.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvDanhSachKT.SelectedRows[0];
                string trangthai = row.Cells["TrangThai"].Value.ToString();

                if(trangthai.Equals("chưa thi"))
                {
                    if (IsAllDigits(txtSlA2.Text) == false || IsAllDigits(txtSlB1.Text) == false || Int32.Parse(txtSlA2.Text) < 0 || Int32.Parse(txtSlB1.Text) < 0)
                    {
                        MessageBox.Show("Số lượng phòng không được chứa chữ và lớn hơn 0 ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        KhoaThi khoaThi = dgvDanhSachKT.CurrentRow.DataBoundItem as KhoaThi;
                        khoaThi.MaKhoaThi = Int32.Parse(row.Cells["MaKhoaThi"].Value.ToString());
                        khoaThi.PhongA2ToiDa = Int32.Parse(txtSlA2.Text);
                        khoaThi.PhongB1ToiDa = Int32.Parse(txtSlB1.Text);
                        if (khoathiBIZ.suaSoLuongPhongThi(khoaThi))
                        {
                            dgvDanhSachKT.Refresh();
                            dgvDanhSachKT.Update();
                            kiemtrakhoathi();
                            MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại do đã có phòng thi ", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thê sửa số lượng phòng của khóa thi đã thi ", "Cảnh báo", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Chọn một khóa thi để sửa ", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void dgvDanhSachKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaThi khoat = dgvDanhSachKT.CurrentRow.DataBoundItem as KhoaThi;
            txtSlA2.Text = khoat.PhongA2ToiDa.ToString();
            txtSlB1.Text = khoat.PhongB1ToiDa.ToString();
        }
    }
}
