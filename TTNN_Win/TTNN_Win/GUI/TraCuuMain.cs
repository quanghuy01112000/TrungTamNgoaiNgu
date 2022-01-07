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
    public partial class TraCuuMain : Form
    {
        ThiSinhTheoPhongThi tracuuBIZ = new ThiSinhTheoPhongThi();
        public TraCuuMain()
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
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtTen.Text.Equals("") || txtSdt.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống tên và số điện thoại ", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                if(IsAllDigits(txtSdt.Text)== false || IsAllLetters(txtTen.Text))
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa số và tên chỉ được chứa chữ ", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    int id = tracuuBIZ.GetIdThiSinh(txtTen.Text, txtSdt.Text);
                    dgvThongTin.AutoGenerateColumns = false;
                    tracuuBIZ.getDSThiSinhTheoPhongThi(id);
                    if(ThiSinhTheoPhongThi.thiSinhTheoPhongThis == null)
                    {
                        MessageBox.Show("Không tìm thấy kết quả ", "Cảnh báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        dgvThongTin.DataSource = ThiSinhTheoPhongThi.thiSinhTheoPhongThis;
                        dgvThongTin.Columns["SBD"].DataPropertyName = "SBD";
                        dgvThongTin.Columns["TenPhongThi"].DataPropertyName = "TenPhongThi";
                        dgvThongTin.Columns["DiemNghe"].DataPropertyName = "DiemNghe";
                        dgvThongTin.Columns["DiemNoi"].DataPropertyName = "DiemNoi";
                        dgvThongTin.Columns["DiemDoc"].DataPropertyName = "DiemDoc";
                        dgvThongTin.Columns["DiemViet"].DataPropertyName = "DiemViet";
                    }
                }
            }
        }
    }
}
