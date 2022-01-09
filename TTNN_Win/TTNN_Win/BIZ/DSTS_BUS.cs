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
    }
}
