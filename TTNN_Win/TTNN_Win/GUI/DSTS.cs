using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNN_Win.GUI
{
    public partial class DSTS : Form
    {
        public DSTS()
        {
            InitializeComponent();
        }

        public DSTS(String maPhongThi)
        {

        }

        private void DSTS_Load(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ChiTIetTS t = new ChiTIetTS();
            t.Show();
        }
    }
}
