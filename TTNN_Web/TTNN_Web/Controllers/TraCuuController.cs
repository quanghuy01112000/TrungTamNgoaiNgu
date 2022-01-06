using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNN_Web.Models;


namespace TTNN_Web.Controllers
{
    public class TraCuuController : Controller
    {
        // GET: TraCuu
        public ActionResult ThongTinThiSinh(string TenThiSinh,string SoDienThoai)
        {
            List<TraCuuViewModel> lstThongTin = new List<TraCuuViewModel>();
            TraCuuModel vi = new TraCuuModel();
            if (!String.IsNullOrEmpty(TenThiSinh) && !String.IsNullOrEmpty(SoDienThoai))
            {
                int id = vi.GetIdThiSinh(TenThiSinh, SoDienThoai);
                lstThongTin = vi.getThongtinbyId(id);
                return View(lstThongTin);
            }
            return View();
        }

        public ActionResult DanhSachThiSinh()
        {
            using (dbEntities db = new dbEntities())
            {
                return View(db.ThiSinhTheoPhongThis.ToList());
            }
                
        }

        public ActionResult GiayChungNhan()
        {
            return View();
        }

        public ActionResult ChiTietGiayChungNhan()
        {
            return View();
        }

        public ActionResult KetQuaThiSinh()
        {
            return View();
        }
        public ActionResult ThongTinChiTietThiSinh()
        {
            return View();
        }




        //=========================================================================
        




        //=========================================================================
    }
}