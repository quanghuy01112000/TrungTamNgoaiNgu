using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.DAL;


namespace TTNN_Win.BIZ
{
    internal class DSTS_BUS
    {
        public static List<ThiSinh> dsTS = new List<ThiSinh>();
        public static List<PhongThi> dsPT = new List<PhongThi>();
        public static List<ThiSinhTheoPhongThi> dsTSPT = new List<ThiSinhTheoPhongThi>();
        public static List<KhoaThi> dsKT = new List<KhoaThi>();
        DSTS_DAO dao = new DSTS_DAO();
        public DSTS_BUS()

        {
            initList();
        }
        
        private void initList()
        {
            dsTS= dao.getListTS();
            dsTSPT = dao.getListTSPT();
            dsPT = dao.getListPT();
            dsKT = dao.getListKT();
        }

        public List<ThiSinhTheoPhongThi> timKiemThiSinhTheoPhongThi(String txt)
        {
            var table = from i in dsTSPT
                        where i.SBD.Contains(txt) || i.MaThiSinh.ToString().Contains(txt) || i.MaPhongThi.ToString().Contains(txt)
                                                  || i.DiemDoc.ToString().Contains(txt) || i.DiemViet.ToString().Contains(txt) || i.DiemNoi.ToString().Contains(txt) || i.DiemViet.ToString().Contains(txt)
                        select i;

            return table.ToList();
        }

        public List<ThiSinhTheoPhongThi> getDanhSachThiSinhCuaPhongThi(int maPhongThi)
        {
            var table = from i in dsTSPT
                        where i.MaPhongThi == maPhongThi
                        select i;
            return table.ToList();
        }
    }
}
