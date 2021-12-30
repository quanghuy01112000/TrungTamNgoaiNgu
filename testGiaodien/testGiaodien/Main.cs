
using System;
using System.Drawing;
using System.Windows.Forms;
using testGiaodien.GUI;

namespace testGiaodien
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

      //  [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
      //  private extern static void ReleaseCapture();

      //  [DllImport("user32.DLL", EntryPoint = "SendMessage")]
     //   private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openChildForm(Form childForm, object btnSender)
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
            //    labelTitle.Text = childForm.Text;

        }
        private void buttonExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBanSach_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1(), sender);
        }

        private void buttonNhapSach_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2(), sender);
        }

        private void btnDSTS_Click(object sender, EventArgs e)
        {
           openChildForm(new DSTS(), sender);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonTacGia_Click(object sender, EventArgs e)
        {
            DSTS d1 = new DSTS();
            d1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
