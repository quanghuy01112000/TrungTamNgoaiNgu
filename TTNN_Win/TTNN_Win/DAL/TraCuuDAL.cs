using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.BIZ;

namespace TTNN_Win.DAL
{
    class TraCuuDAL
    {
       
        public int GetIdThiSinh(string ten, string sdt)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var table = from t in db.ThiSinhs
                            where t.TenThiSinh.ToLower().Contains(ten) || t.SoDienThoai.Contains(sdt)
                            select t;
                return table.FirstOrDefault().MaThiSinh;
            }

        }
        public List<ThiSinhTheoPhongThi> getThongtinbyId(int mathisinh)
        {
            List<ThiSinhTheoPhongThi> thisinh = new List<ThiSinhTheoPhongThi>();
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var table = from t in db.ThiSinhTheoPhongThis
                            where t.MaThiSinh == mathisinh
                            select t;
                foreach(var t in table)
                {
                    thisinh.Add(new ThiSinhTheoPhongThi
                    {
                        DiemDoc = t.DiemDoc,
                        DiemNghe = t.DiemNghe,
                        DiemNoi = t.DiemDoc,
                        DiemViet = t.DiemViet,
                        SBD = t.SBD,
                        TenPhongThi = t.PhongThi.TenPhongThi
                    });         
                }
                return thisinh;
            }
        }

    }
}
