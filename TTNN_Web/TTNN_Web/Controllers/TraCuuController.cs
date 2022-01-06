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
        public ActionResult ThongTinThiSinh()
        {
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

        public ActionResult KetQuaThiSinh()
        {
            return View();
        }

        public ActionResult ThongTinChiTietThiSinh()
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