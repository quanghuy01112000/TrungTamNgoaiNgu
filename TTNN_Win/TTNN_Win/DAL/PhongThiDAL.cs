using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.BIZ;

namespace TTNN_Win.DAL
{
    class PhongThiDAL
    {
        public List<PhongThi> getDanhSachPhongThi()
        {
            List<PhongThi> dsPhongThi = new List<PhongThi>();
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var table = from t in db.PhongThis
                            select t;
                return table.ToList();
            }
        }
        public Boolean themPhongThi(PhongThi phongthi)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {

                db.PhongThis.Add(phongthi);
                db.SaveChanges();
            }
            return true;
        }
        public Boolean taoPhongThiTuDong(PhongThi phongThi)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                db.PhongThis.Add(phongThi);
                db.SaveChanges();
            }
            return true;
        }

        public Boolean themThiSinhVaoPhongThi(ThiSinhTheoPhongThi thiSinhTheoPhongThi)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                db.ThiSinhTheoPhongThis.Add(thiSinhTheoPhongThi);
                db.SaveChanges();
            }
            return true;
        }
        public int getSoLuongThiSinhA2()
        {
            ThiSinh busThiSinh = new ThiSinh();
            int count;
            int maKhoaThi = busThiSinh.getKhoaThiByTrangThai().MaKhoaThi;
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                count = db.ThiSinhCuaKhoaThis.Where(p => p.TrinhDo == "A2" && p.MaKhoaThi == maKhoaThi).Count();

            }
            return count;
        }


        public int getSoLuongThiSinhB1()
        {
            ThiSinh busThiSinh = new ThiSinh();
            int count;
            int maKhoaThi = busThiSinh.getKhoaThiByTrangThai().MaKhoaThi;
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                count = db.ThiSinhCuaKhoaThis.Where(p => p.TrinhDo == "B1" && p.MaKhoaThi == maKhoaThi).Count();

            }
            return count;
        }
        public Boolean xoaPhongThi(int maphongthi)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                PhongThi phongthhi = db.PhongThis.Find(maphongthi);
                if (phongthhi.ThiSinhTheoPhongThis.Count > 0)
                {
                    return false;
                }
                else
                {
                    db.PhongThis.Remove(phongthhi);
                    db.SaveChanges();
                }
            }
            return true;
        }
        public Boolean suaPhongThi(PhongThi phongthi)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                PhongThi phongthiDB = db.PhongThis.Find(phongthi.MaPhongThi);
                if (phongthiDB.ThiSinhTheoPhongThis.Count > 0)
                {
                    return false;
                }
                else
                {
                    phongthiDB.TenPhongThi = phongthi.TenPhongThi;
                    phongthiDB.TrinhDo = phongthi.TrinhDo;
                    phongthiDB.SoLuongThiSinh = phongthi.SoLuongThiSinh;
                    db.SaveChanges();
                }
                return true;
            }
        }
        public Boolean suaSoLuong(PhongThi phongthi)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                PhongThi phongthiDB = db.PhongThis.Find(phongthi.MaPhongThi);
                if (phongthiDB.ThiSinhTheoPhongThis.Count > 0)
                {
                    return false;
                }
                else
                {
                    phongthiDB.SoLuongThiSinh = phongthi.SoLuongThiSinh;
                    db.SaveChanges();
                }
                return true;
            }
        }
        public int getMakhoaThiCuoi()
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var table = from t in db.KhoaThis
                            orderby t.MaKhoaThi descending
                            select t;
                return table.FirstOrDefault().MaKhoaThi;

            }
        }

        public string getNameById(int id)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                KhoaThi khoathi = db.KhoaThis.Find(id);
                return khoathi.TenKhoaThi;

            }
        }
        public string getTrangThaiCuoi()
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
