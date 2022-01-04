using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.DAL;

namespace TTNN_Win.BIZ
{
    partial class ThiSinh
    {
        public static List<ThiSinh> listThiSinh = null;
        public static List<KhoaThi> listKhoaThi = null;
        DAO_QuanLyThiSinh daoQuanLyThiSinh = new DAO_QuanLyThiSinh();

        public static List<string> listTrinhDo = new List<string>(new string[] { "A2", "B1" });
        public void getDanhSachThiSinh()
        {
            listThiSinh = daoQuanLyThiSinh.getDanhSachThiSinh();
            listThiSinh = listThiSinh.OrderBy(t => t.MaThiSinh).ToList();
        }
        public KhoaThi getKhoaThiByTrangThai()
        {
            return daoQuanLyThiSinh.getKhoaThiByTrangThai();
        }
        public Boolean suaThisinh(ThiSinh thiSinh)
        {
            return daoQuanLyThiSinh.suaThiSinh(thiSinh);
        }
        public Boolean themThiSinh(ThiSinh thiSinh)
        {
            listThiSinh.Add(thiSinh);
            return daoQuanLyThiSinh.themThiSinh(thiSinh);
        }
        public Boolean xoaThiSinh(ThiSinh thiSinh)
        {
            if (daoQuanLyThiSinh.xoaThiSinh(thiSinh.MaThiSinh))
            {
                listThiSinh.Remove(thiSinh);
                return true;
            }
            else return false;
        }
        public List<ThiSinh> timKiemThiSinh(String textSearch)
        {
            var table = from t in listThiSinh
                        where t.TenThiSinh.ToLower().Contains(textSearch) || t.Cmnd.ToString().Contains(textSearch)
                        select t;
            return table.ToList();
        }
        public int getMaThiSinhMax()
        {
            if (listThiSinh != null)
            {
                return listThiSinh.Last().MaThiSinh;
            }
            else return 1;
        }
        public int getMaThiSinhFirst()
        {
            List<ThiSinh> listGetDanhSachThiSinh = null;
            listGetDanhSachThiSinh = daoQuanLyThiSinh.getDanhSachThiSinh();
            listGetDanhSachThiSinh = listGetDanhSachThiSinh.OrderByDescending(t => t.MaThiSinh).ToList();
            if (listGetDanhSachThiSinh != null)
            {
                return listGetDanhSachThiSinh.FirstOrDefault().MaThiSinh;
            }
            else return -1;
        }
    }
}
