using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNN_Win.DAL;
using TTNN_Win.DTO;

namespace TTNN_Win.BIZ
{
    public class BIZ_NhapDiem
    {
        public static List<PhongThi> dsPT = new List<PhongThi>();
        public static List<ThiSinhTheoPhongThi> dsTSPT = new List<ThiSinhTheoPhongThi>();
        public static List<KhoaThi> dsKT = new List<KhoaThi>();
        public static List<DTOThiSinh> dsTS = new List<DTOThiSinh>();

        DAL_NhapDiem dao = new DAL_NhapDiem();

        //public void getDanhSachTSTheoPhong(int MaPhongThi)
        //{
        //    dsTSPT = dao.getListTSPT(MaPhongThi);
        //    dsTSPT = dsTSPT.OrderBy(t => t.SBD).ToList();
        //}

        public List<KhoaThi> getDanhSachKT()
        {
            return dao.getListKT();
        }

        public List<ThiSinhTheoPhongThi> getThiSinh(int maKhoaThi)
        {
            return dao.getListTSPT(maKhoaThi);
        }

        public List<PhongThi> getDanhSachPhongThi(int maKhoaThi)
        {
            //dsPT = dao.getListPT(maKhoaThi);
            //dsPT.OrderBy(t => t.MaPhongThi).ToList();
            return dao.getListPT(maKhoaThi);
        }

        public bool capNhapThiSinh (List<ThiSinhTheoPhongThi> listThiSinh)
        {
         
            return dao.CapNhapDiemThi(listThiSinh);
        }

        public List<String> getDSTenTS(int maPhongThi)
        {
            return dao.getDSTenTS(maPhongThi);
        }

        public List<DTOThiSinh> getListAllInfoTS(int maPhongThi)
        {
            return dao.getListTSPTFull(maPhongThi);
        }
    }
}
