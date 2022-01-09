using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN_Web.Models
{
    class TraCuuModel
    {
        public static List<TraCuuViewModel> thiSinhTheoPhongThis = null;
        public int GetIdThiSinh(string ten, string sdt)
        {
            using (dbEntities db = new dbEntities())
            {
                var table = from t in db.ThiSinhs
                            where t.TenThiSinh.ToLower().Equals(ten) || t.SoDienThoai.Equals(sdt)
                            select t;
                if (table.Any())
                return table.FirstOrDefault().MaThiSinh;
                return 0;
            }
        }
        public List<TraCuuViewModel> getThongtinbyId(int mathisinh)
        {
            List<TraCuuViewModel> thisinh = new List<TraCuuViewModel>();
            using (dbEntities db = new dbEntities())
            {
                var table = from t in db.ThiSinhTheoPhongThis
                            where t.MaThiSinh == mathisinh
                            select t;
                foreach(var t in table)
                {
                    thisinh.Add(new TraCuuViewModel
                    {
                        DiemDoc = (int)t.DiemDoc,
                        DiemNghe = (int)t.DiemNghe,
                        DiemNoi = (int)t.DiemDoc,
                        DiemViet = (int)t.DiemViet,
                        SBD = t.SBD,
                        TenPhongThi = t.PhongThi.TenPhongThi
                    });         
                }
                return thisinh;
            }
        }
        public void getDSThiSinhTheoPhongThi(int mathisinh)
        {
            thiSinhTheoPhongThis = getThongtinbyId(mathisinh);
            thiSinhTheoPhongThis = thiSinhTheoPhongThis.OrderBy(t => t.MaThiSinh).ToList();
        }
    }
}
