using System;
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
            TraCuu vi = new TraCuu();
            if (!String.IsNullOrEmpty(TenThiSinh) && !String.IsNullOrEmpty(SoDienThoai))
            {
                int id = vi.GetIdThiSinh(TenThiSinh, SoDienThoai);
                lstThongTin = vi.getThongtinbyId(id);
                return View(lstThongTin);
            }
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

        [HttpGet]
        public ActionResult GiayChungNhan(int? maThiSinh)
        {
            using (dbEntities db = new dbEntities())
            {
                var ts = (from i in db.ThiSinhs
                         where i.MaThiSinh == maThiSinh
                         select i.TenThiSinh).FirstOrDefault();
                var td = (from i in db.PhongThis
                          join j in db.ThiSinhTheoPhongThis on i.MaPhongThi equals j.MaPhongThi
                          where j.MaThiSinh == maThiSinh
                          select i.TrinhDo).FirstOrDefault();
                var k = (from i in db.KhoaThis
                         where i.MaKhoaThi == KhoaHienTai
                         select i.NgayThi).FirstOrDefault();
                model = new ExpandoObject();
                model.TenThiSinh = ts;
                model.TrinhDo = td;
                model.NgayThi = k.ToString();

                return View();
            }
        }
        [HttpGet]
        public ActionResult ChiTietGiayChungNhan(int? id)
        {
            using (dbEntities db = new dbEntities())
            {
                var kh = from i in db.KhoaThis
                        select i.MaKhoaThi;
                foreach (int i in kh)
                {
                    if (i > KhoaHienTai) KhoaHienTai = i;
                }
                var ts = (from i in db.ThiSinhs
                          where i.MaThiSinh == id
                          select i.TenThiSinh).FirstOrDefault();
                var td = (from i in db.ThiSinhCuaKhoaThis
                         select i.TrinhDo).FirstOrDefault();
                          
                var k = (from i in db.KhoaThis
                         where i.MaKhoaThi == KhoaHienTai
                         select i.NgayThi).FirstOrDefault();
                model = new ExpandoObject();
                model.TenThiSinh = ts;
                model.TrinhDo = td;
                String NgayThi = k.ToString();
                model.NgayThi = NgayThi;

                return View(model);
            }
        }

        public ActionResult KetQuaThiSinh()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ThongTinChiTietThiSinh(int? id)
        {
            using (dbEntities db = new dbEntities())
            {
                var kh = from i in db.KhoaThis
                         select i.MaKhoaThi;
                foreach (int i in kh)
                {
                    if (i > KhoaHienTai) KhoaHienTai = i;
                }

                var tspt = (from i in db.ThiSinhTheoPhongThis
                            where i.MaThiSinh == id
                            select i).FirstOrDefault();
                var p = (from i in db.PhongThis
                         where tspt.MaPhongThi == i.MaPhongThi
                         select i).FirstOrDefault();
                var k = (from i in db.KhoaThis
                         where i.MaKhoaThi == KhoaHienTai
                         select i.NgayThi).FirstOrDefault().ToString();
                model = new ExpandoObject();
                model.SBD = tspt.SBD;
                model.PhongThi = p.TenPhongThi;
                model.NgayThi = k;
                model.DiemNghe = tspt.DiemNghe;
                model.DiemNoi = tspt.DiemNoi;
                model.DiemViet = tspt.DiemViet;
                model.DiemDoc = tspt.DiemDoc;

                return View(model);
            }
        }




        //=========================================================================





        //=========================================================================
    }
}