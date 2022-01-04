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
            openChildForm(new KhoaThi(), sender);
        }

        private void btnThiSinh_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.DSTS(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.NhapDiem(), sender);
        }
    }
}
