﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNN_Web.Models;


namespace TTNN_Web.Controllers
{
    public class TraCuuController : Controller
    {
        dynamic model = new ExpandoObject();
        int KhoaHienTai = 0;
        int PhongHienTai = 0;

        // GET: TraCuu
        public ActionResult ThongTinThiSinh(string TenThiSinh, string SoDienThoai)
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

        public ActionResult ThongTinThiSinh()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DanhSachThiSinh()
        {


            using (dbEntities db = new dbEntities())
            {
                var k = from i in db.KhoaThis
                        select i.MaKhoaThi;
                foreach (int i in k)
                {
                    if (i > KhoaHienTai) KhoaHienTai = i;
                }

                var dspt = from p in db.PhongThis
                           where p.MaKhoaThi == KhoaHienTai
                           select p;

                foreach (PhongThi i in dspt)
                {
                    PhongHienTai = i.MaPhongThi;
                    break;
                }
                var dstspt = from i in db.ThiSinhTheoPhongThis
                             join j in db.PhongThis on i.MaPhongThi equals j.MaPhongThi
                             where j.MaKhoaThi == KhoaHienTai && i.MaPhongThi == PhongHienTai
                             select i;
                var dsts = from i in db.ThiSinhs
                           join j in dstspt on i.MaThiSinh equals j.MaThiSinh
                           select i;

                model.dstspt = dstspt.ToList();
                model.dspt = dspt.ToList();
                model.dsts = dsts.ToList();
                return View(model);
            }

        }


        public ActionResult DanhSachThiSinh(FormCollection f)
        {
            using (dbEntities db = new dbEntities())
            {
                var k = from i in db.KhoaThis
                        select i.MaKhoaThi;
                foreach (int i in k)
                {
                    if (i > KhoaHienTai) KhoaHienTai = i;
                }
                var dspt = from p in db.PhongThis
                           where p.MaKhoaThi == KhoaHienTai
                           select p;
                String phongthi = f["phong"];
                foreach (PhongThi i in dspt)
                {
                    if (phongthi.Equals(i.TenPhongThi))
                    {
                        PhongHienTai = i.MaPhongThi;
                        break;
                    }
                }
                var dstspt = from i in db.ThiSinhTheoPhongThis
                             join j in db.PhongThis on i.MaPhongThi equals j.MaPhongThi
                             where j.MaKhoaThi == KhoaHienTai && i.MaPhongThi == PhongHienTai
                             select i;
                var dsts = from i in db.ThiSinhs
                           join j in dstspt on i.MaThiSinh equals j.MaThiSinh
                           select i;


                model = new ExpandoObject();
                model.dsts = dsts.ToList();
                model.dstspt = dstspt.ToList();
                model.phongthi = PhongHienTai;
                model.dspt = dspt.ToList();
                return View(model);
            }
        }

        [HttpPost]
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