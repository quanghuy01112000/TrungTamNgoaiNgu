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
    public partial class ChiTIetTS : Form
    {
        ThiSinh ts = new ThiSinh();
        ThiSinhTheoPhongThi tspt= new ThiSinhTheoPhongThi();
        public ChiTIetTS()
        {
            InitializeComponent();
        }

        public ChiTIetTS(ThiSinh ts,ThiSinhTheoPhongThi tspt,DateTime ngayThi)
        {
            InitializeComponent();
            this.ts = ts;
            this.tspt = tspt;
            load(ngayThi);
        }

        private void ChiTIetTS_Load(object sender, EventArgs e)
        {

        }

        private void load(DateTime ngayThi)
        {
            lblHoTen.Text = ts.TenThiSinh;
            lblMaThiSinh.Text = ts.MaThiSinh.ToString();
            lblNgayThi.Text = ts.NgaySinh.ToString();
            lblCMND.Text = ts.Cmnd;
            lblSDT.Text = ts.SoDienThoai;
            lblMaThiSinh.Text = ts.MaThiSinh.ToString();

            lblNgayThi.Text = ngayThi.ToString();
            lblSoBaoDanh.Text = tspt.SBD;

            lblDiemNghe.Text = tspt.DiemNghe.ToString();
            lblDiemNoi.Text = tspt.DiemNoi.ToString();
            lblDiemDoc.Text = tspt.DiemDoc.ToString();
            lblDiemViet.Text = tspt.DiemViet.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
