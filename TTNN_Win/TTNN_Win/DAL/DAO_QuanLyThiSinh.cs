﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.BIZ;

namespace TTNN_Win.DAL
{
    internal class DAO_QuanLyThiSinh
    {
        public List<ThiSinh> getDanhSachThiSinh()
        {
            List<ThiSinh> dsThiSinh = new List<ThiSinh>();
            using(QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var table = from t in db.ThiSinhs
                            select t;
                foreach(var i in table)
                {
                    ThiSinh thiSinh = new ThiSinh();
                    thiSinh.MaThiSinh = i.MaThiSinh;
                    thiSinh.TenThiSinh = i.TenThiSinh;
                    thiSinh.NgaySinh = i.NgaySinh;
                    thiSinh.GioiTinh = i.GioiTinh;
                    thiSinh.Cmnd = i.Cmnd;
                    thiSinh.SoDienThoai = i.SoDienThoai;
                    dsThiSinh.Add(thiSinh);
                }
                return dsThiSinh;
            }
        }
        public Boolean suaThiSinh(ThiSinh thiSinh)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                ThiSinh thiSinhDB = db.ThiSinhs.Find(thiSinh.MaThiSinh);
                thiSinhDB.TenThiSinh = thiSinh.TenThiSinh;
                thiSinhDB.NgaySinh = thiSinh.NgaySinh;
                thiSinhDB.GioiTinh = thiSinh.GioiTinh;
                thiSinhDB.Cmnd = thiSinh.Cmnd;
                thiSinhDB.SoDienThoai = thiSinh.SoDienThoai;
                db.SaveChanges();

            }  
            return true;
        }
        public Boolean themThiSinh(ThiSinh thiSinh)
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                db.ThiSinhs.Add(thiSinh);
                db.SaveChanges();
            }
            return true;
        }
        public Boolean xoaThiSinh(int maThiSinh)
        {
            using(QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                ThiSinh thiSinh = db.ThiSinhs.Find(maThiSinh);
                if (thiSinh.ThiSinhCuaKhoaThis.Count() > 0 || thiSinh.ThiSinhTheoPhongThis.Count() > 0)
                    return false;
                else
                {
                    db.ThiSinhs.Remove(thiSinh);
                    db.SaveChanges();
                }
            }
            return true;
        }

        public KhoaThi getKhoaThiByTrangThai()
        {
            using (QL_TT_NGOAINGUEntities db = new QL_TT_NGOAINGUEntities())
            {
                var table = from h in db.KhoaThis
                            where !h.TrangThai.Equals("đã kết thúc")
                            select h;
                KhoaThi khoaThi = new KhoaThi();
                foreach (var h in table)
                {
                    khoaThi.MaKhoaThi = h.MaKhoaThi;
                    khoaThi.TenKhoaThi = h.TenKhoaThi;
                    khoaThi.NgayThi = h.NgayThi;
                    khoaThi.TrangThai = h.TrangThai;
                }
                return khoaThi;
            }
        }
    }
}
