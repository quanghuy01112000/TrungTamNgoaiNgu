using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.DAL;

namespace TTNN_Win.BIZ
{
    partial class KhoaThi
    {
        public static List<KhoaThi> listKhoaThi = null;
        KhoaThiDAL khoathiDAL = new KhoaThiDAL();

        public void getDSKhoaThi()
        {
            listKhoaThi = khoathiDAL.getDanhSachKhoaThi();
            listKhoaThi = listKhoaThi.OrderBy(t => t.MaKhoaThi).ToList();
        }
        
        public Boolean themKhoaThi(KhoaThi khoathi)
        {
            listKhoaThi.Add(khoathi);
            return khoathiDAL.themKhoaThi(khoathi);
        }

        public Boolean suaKhoaThi(KhoaThi khoaThi)
        {
            return khoathiDAL.suaKhoaThi(khoaThi);
        }

        public Boolean xoaKhoaThi(KhoaThi khoaThi)
        {
            if (khoathiDAL.xoaKhoaThi(khoaThi.MaKhoaThi))
            {
                listKhoaThi.Remove(khoaThi);
                return true;
            }
            else
            {
                return false;
            }
        }
        public DateTime getNgayCuoi()
        {
            return khoathiDAL.getNgayCuoi();
        }
        public String getTrangThaiCuoi()
        {
            return khoathiDAL.getTrangThaiCuoi();
        }
    }
}
