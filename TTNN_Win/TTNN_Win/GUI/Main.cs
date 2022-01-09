using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTNN_Win.GUI
{
    public partial class Main : Form
    {
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
            buttonCloseChildForm.Visible = false;
            this.Text = string.Empty;
        }

        private void openChildForm(Form childForm , object btnSender)
        {
            if (activeForm != null)
            {
                //activeForm.Close();
                activeForm.Dispose();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDeskTop.Controls.Add(childForm);
            this.panelDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;

        }
        private void buttonExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKhoaThi_Click(object sender, EventArgs e)
        {
            openChildForm(new KhoaThiMain(), sender);
            labelTitle.Text="Khóa thi";
        }

        private void btnThiSinh_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.QuanLyThiSinh(), sender);
        }

        private void btnPhongThi_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.DSTS(), sender);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.NhapDiem(), sender);
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

		}

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            openChildForm(new TraCuuMain(), sender);
            labelTitle.Text = "Tra cứu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new PhongThiMain(), sender);
        }
    }
}
