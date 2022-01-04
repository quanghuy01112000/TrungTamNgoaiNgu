using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.BIZ;

namespace TTNN_Win.DAL
{
    internal class DSTS_DAO

    {
        
        public List<ThiSinh> getListTS()
        {
            List<ThiSinh> tmp = new List<ThiSinh>();
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var ts= from i in db.ThiSinhs
                        select i;
                foreach(ThiSinh t in ts)
                {
                    ThiSinh tmp2 = new ThiSinh();
                    tmp2.MaThiSinh = t.MaThiSinh;
                    tmp2.NgaySinh = t.NgaySinh;
                    tmp2.SoDienThoai = t.SoDienThoai;
                    tmp2.TenThiSinh = t.TenThiSinh;
                    tmp2.GioiTinh = t.GioiTinh;
                    tmp2.Cmnd = t.Cmnd;
                    tmp.Add(tmp2);
                }
            }
            return tmp;
        }
        
        public List<ThiSinhTheoPhongThi> getListTSPT()
        {   
            List<ThiSinhTheoPhongThi> tmp = new List<ThiSinhTheoPhongThi>();
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var ts = from i in db.ThiSinhTheoPhongThis
                         select i;
                
                foreach (ThiSinhTheoPhongThi t in ts)
                {
                    ThiSinhTheoPhongThi tmp2 = new ThiSinhTheoPhongThi();
                    tmp2.MaThiSinh = t.MaThiSinh;
                    tmp2.MaPhongThi = t.MaPhongThi; 
                    tmp2.SBD = t.SBD;
                    tmp2.DiemDoc = t.DiemDoc;
                    tmp2.DiemNghe = t.DiemNghe;
                    tmp2.DiemNoi = t.DiemNoi;
                    tmp2.DiemViet = t.DiemViet;
                    tmp.Add(tmp2);
                }
            }
            return tmp;
        }

        public List<PhongThi> getListPT()
        {
            List<PhongThi> tmp = new List<PhongThi>();
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities()){
                var pt = from i in db.PhongThis
                         select i;
                foreach(PhongThi p in pt)
                {
                    PhongThi tmp2 = new PhongThi();
                    tmp2.TrinhDo = p.TrinhDo;
                    tmp2.MaPhongThi = p.MaPhongThi;
                    tmp2.TenPhongThi = p.TenPhongThi;
                    tmp2.SoLuongThiSinh = p.SoLuongThiSinh;
                    tmp2.MaKhoaThi = p.MaKhoaThi;
                    tmp.Add(tmp2);
                }
            }
            return tmp;
        }

        public List<KhoaThi> getListKT()
        {
            List<KhoaThi> tmp = new List<KhoaThi>();
            using(QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var kt = from i in db.KhoaThis
                         select i;
                foreach(KhoaThi k in kt)
                {
                    KhoaThi tmp2 = new KhoaThi();
                    tmp2.MaKhoaThi = k.MaKhoaThi;
                    tmp2.TenKhoaThi=k.TenKhoaThi;
                    tmp2.NgayThi = k.NgayThi;
                    tmp2.TrangThai = k.TrangThai;
                    tmp.Add(tmp2);
                }
            }
            return tmp;
        }
    }
}
