using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.BIZ;

namespace TTNN_Win.DAL
{
    class KhoaThiDAL
    {
        public List<KhoaThi> getDanhSachKhoaThi()
        {
            List<KhoaThi> dsKhoaThi = new List<KhoaThi>();
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var table = from t in db.KhoaThis
                            select t;
                foreach(var i in table)
                {
                    KhoaThi khoathi = new KhoaThi();
                    khoathi.MaKhoaThi = i.MaKhoaThi;
                    khoathi.TenKhoaThi = i.TenKhoaThi;
                    khoathi.NgayThi = i.NgayThi;
                    khoathi.TrangThai = i.TrangThai;
                    dsKhoaThi.Add(khoathi);
                }
                return table.ToList();
            }
        }
        
        public Boolean themKhoaThi(KhoaThi khoathi)
        {
            using(QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                db.KhoaThis.Add(khoathi);
                db.SaveChanges();
            }
            return true;
        }

        public Boolean xoaKhoaThi(int makhoathi)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                KhoaThi khoaThi = db.KhoaThis.Find(makhoathi);
                if(khoaThi.ThiSinhCuaKhoaThis.Count > 0)
                {
                    return false;
                }
                else
                {
                    db.KhoaThis.Remove(khoaThi);
                    db.SaveChanges();
                }
            }
            return true;
        }

        public Boolean suaKhoaThi(KhoaThi khoathi)
        {
            using(QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                KhoaThi khoathiDb = db.KhoaThis.Find(khoathi.MaKhoaThi);
                if (khoathiDb.ThiSinhCuaKhoaThis.Count > 0)
                {
                    return false;
                }
                else
                {
                    khoathiDb.TenKhoaThi = khoathi.TenKhoaThi;
                    khoathiDb.NgayThi = khoathi.NgayThi;
                    khoathiDb.TrangThai = khoathi.TrangThai;
                    db.SaveChanges();
                }
            }
            return true;
        }
        public DateTime getNgayCuoi()
        {
            using(QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var table = from t in db.KhoaThis
                            orderby t.MaKhoaThi descending
                            select t;
                return (DateTime)table.FirstOrDefault().NgayThi;

            }
        }
        public String getTrangThaiCuoi()
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var table = from t in db.KhoaThis
                            orderby t.MaKhoaThi descending
                            select t;
                return table.FirstOrDefault().TrangThai.ToString();

            }
        }
    }
}
