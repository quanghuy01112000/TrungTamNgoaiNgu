using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNN_Web.Models;

namespace TTNN_Web.Controllers
{
    public class ThongKeController : Controller
    {
        // GET: ThongKe
        public ActionResult ThongKeA2()
        {
            using (dbEntities db = new dbEntities())
            {
                var pt = from i in db.PhongThis
                         where i.TrinhDo.Equals("A2")
                         select i;
                int coutPT = pt.Count();
                ViewData["countPT"] = coutPT.ToString();

                var kt = from i in db.KhoaThis
                         where i.TrangThai.Equals("đã kết thúc")
                         select i;
                int countKT = kt.Count();
                ViewData["countKT"] = countKT.ToString();
                
                var ts = from i in db.ThiSinhCuaKhoaThis
                         where i.TrinhDo.Equals("A2")
                         select i;
                int countTS = ts.Count();
                ViewData["countTS"] = countTS.ToString();
                return View();
            }
        }

        public ActionResult ThongKeB1()
        {
            using (dbEntities db = new dbEntities())
            {
                var pt = from i in db.PhongThis
                         where i.TrinhDo.Equals("B1")
                         select i;
                int coutPT = pt.Count();
                ViewData["countPTB1"] = coutPT.ToString();

                var kt = from i in db.KhoaThis
                         where i.TrangThai.Equals("đã kết thúc")
                         select i;
                int countKT = kt.Count();
                ViewData["countKTB1"] = countKT.ToString();

                var ts = from i in db.ThiSinhCuaKhoaThis
                         where i.TrinhDo.Equals("B1")
                         select i;
                int countTS = ts.Count();
                ViewData["countTSB1"] = countTS.ToString();
                return View();
            }
        }
    }
}