using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNN_Web.Models;

namespace TTNN_Web.Controllers
{
    public class DangKyController : Controller
    {

        // GET: DangKy
        public ActionResult Index()
        {
            if (getKhoaThiByTrangThai() == 0)
            {
                ViewData["mes"] = "Không có khóa thi đang mở " + getKhoaThiByTrangThai();
                return View();
            }
            ViewData["mes"] = "" + getKhoaThiByTrangThai() + " " + getMaxCount();
            return View();
        }

        //public ActionResult AddThiSinh(ThiSinh thiSinh)
        //{
            
        //    ThiSinh newThiSinh = new ThiSinh();

        //    int idmax = getMaxCount() + 1;
        //    newThiSinh.MaThiSinh = idmax;
        //    newThiSinh.TenThiSinh = thiSinh.TenThiSinh;
        //    newThiSinh.NgaySinh = thiSinh.NgaySinh;
        //    newThiSinh.GioiTinh = thiSinh.GioiTinh;
        //    newThiSinh.Cmnd = thiSinh.Cmnd;
        //    newThiSinh.SoDienThoai = thiSinh.SoDienThoai;

        //    ThiSinhCuaKhoaThi thiSinhCuaKhoaThi = new ThiSinhCuaKhoaThi();
        //    thiSinhCuaKhoaThi.MaThiSinh = idmax;
        //    thiSinhCuaKhoaThi.MaKhoaThi = getKhoaThiByTrangThai();
        //    if (themThiSinh(newThiSinh) && themThiSinhTrongKhoaThi(thiSinhCuaKhoaThi, idmax))
        //        return RedirectToAction("Index");
        //    return View();
        //}

        public ActionResult AddThiSinh(FormCollection f)
        {
            Boolean check = false;
            
                ThiSinh newThiSinh = new ThiSinh();
                
                DateTime myDate;
                
                myDate = DateTime.ParseExact(f["NgaySinh"], "yyyy-MM-dd",
                                            System.Globalization.CultureInfo.InvariantCulture);
               
                    
                
                int idmax = getMaxCount() + 1;
                newThiSinh.MaThiSinh = idmax;
                newThiSinh.TenThiSinh = f["TenThiSinh"].ToString();
                newThiSinh.NgaySinh = myDate;
                newThiSinh.GioiTinh = f["GioiTinh"].ToString();
                newThiSinh.Cmnd = f["CMND"].ToString();
                newThiSinh.SoDienThoai = f["SDT"].ToString();

                ThiSinhCuaKhoaThi thiSinhCuaKhoaThi = new ThiSinhCuaKhoaThi();
                thiSinhCuaKhoaThi.MaThiSinh = idmax;
                thiSinhCuaKhoaThi.MaKhoaThi = getKhoaThiByTrangThai();
                thiSinhCuaKhoaThi.TrinhDo = f["TrinhDo"].ToString();
                if (themThiSinh(newThiSinh) && themThiSinhTrongKhoaThi(thiSinhCuaKhoaThi))
                    check = true;
            

            if(check)
                return Redirect("/Home/Index");
            return RedirectToAction("index");
        }

        public int getMaxCount()
        {
            using (dbEntities db = new dbEntities())
            {
                var max = db.ThiSinhs.DefaultIfEmpty().Max(r => r == null ? 0 : r.MaThiSinh);
                return max;
            }

        }

        public Boolean themThiSinh(ThiSinh thiSinh)
        {
            using (dbEntities db = new dbEntities())
            {
                db.ThiSinhs.Add(thiSinh);
                db.SaveChanges();
            }
            return true;
        }
        public Boolean themThiSinhTrongKhoaThi(ThiSinhCuaKhoaThi thiSinhCuaKhoaThi)
        {
            using (dbEntities db = new dbEntities())
            {
                
                db.ThiSinhCuaKhoaThis.Add(thiSinhCuaKhoaThi);
                db.SaveChanges();
            }
            return true;
        }

        public int getKhoaThiByTrangThai()
        {
            using (dbEntities db = new dbEntities())
            {
                //DateTime now = DateTime.Now;
                //DateTime dateAfterAdd = now.AddDays(5);
                //var table = from h in db.KhoaThis
                //where h.NgayThi > dateAfterAdd
                //select h;
                var table = from h in db.KhoaThis
                            where !h.TrangThai.Equals("đã kết thúc")
                            select h.MaKhoaThi;
                if (table != null)
                    return Convert.ToInt32(table.FirstOrDefault());
                else
                    return 0;

            }

        }
    }
}