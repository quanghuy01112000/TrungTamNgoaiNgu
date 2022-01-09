using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.DAL;

namespace TTNN_Win.BIZ
{
    partial class ThiSinhTheoPhongThi
    {
        public static List<ThiSinhTheoPhongThi> thiSinhTheoPhongThis = null;
        TraCuuDAL tracuuDAL = new TraCuuDAL();
        public string TenPhongThi { get; set; }
        

        public int GetIdThiSinh(string ten, string sdt)
        {
            return tracuuDAL.GetIdThiSinh(ten, sdt);
        }
        public void getDSThiSinhTheoPhongThi(int mathisinh)
        {

            thiSinhTheoPhongThis = tracuuDAL.getThongtinbyId(mathisinh);
            thiSinhTheoPhongThis = thiSinhTheoPhongThis.OrderBy(t => t.MaThiSinh).ToList();
        }
    }
}
