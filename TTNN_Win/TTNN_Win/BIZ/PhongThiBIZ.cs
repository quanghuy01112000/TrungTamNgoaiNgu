using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.DAL;

namespace TTNN_Win.BIZ
{
    partial class PhongThi
    {
        public static List<PhongThi> listPhongThi = null;
        PhongThiDAL phongthiDAL = new PhongThiDAL();
        public void getDSPhongThi()
        {
            listPhongThi = phongthiDAL.getDanhSachPhongThi();
            listPhongThi = listPhongThi.OrderBy(t => t.MaPhongThi).ToList();
        }
        public Boolean themPhongThi(PhongThi phongthi)
        {
            listPhongThi.Add(phongthi);
            return phongthiDAL.themPhongThi(phongthi);
        }
        public Boolean xoaPhongThi(PhongThi phongthi)
        {
            if (phongthiDAL.xoaPhongThi(phongthi.MaPhongThi))
            {
                listPhongThi.Remove(phongthi);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean suaPhongThi(PhongThi phongthi)
        {
            return phongthiDAL.suaPhongThi(phongthi);
        }
        public Boolean suaSoluong(PhongThi phongthi)
        {
            return phongthiDAL.suaSoLuong(phongthi);
        }
        public int getMaKhoaThiCuoi()
        {
            return phongthiDAL.getMakhoaThiCuoi();
        }
        public string getNameById(int id)
        {
            return phongthiDAL.getNameById(id);
        }
        public string getTrangThaiCuoi()
        {
            return phongthiDAL.getTrangThaiCuoi();
        }
    }
}
