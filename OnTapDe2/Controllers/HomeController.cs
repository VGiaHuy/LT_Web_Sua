using OnTapDe2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnTapDe2.Controllers
{
    public class HomeController : Controller
    {
        QLBanHangQuanAoEntities db = new QLBanHangQuanAoEntities();

        public ActionResult Index()
        {
            // lấy ra danh sách sản phẩm từ database
            var sp = db.SanPhams.ToList();

            // gán danh sách phân loại phụ vào ViewBag
            ViewBag.PhanLoaiPhu = db.PhanLoaiPhus.ToList();

            return View(sp);
        }

        [HttpPost]
        public ActionResult GetProductByCategory(string phanLoai)
        {
            // trường hợp người dùng chọn "Tất cả sản phẩm"
            if (phanLoai == "Tất cả sản phẩm")
            {
                // lấy ra tất cả sản phẩm
                var sanPham1 = db.SanPhams.ToList();

                // bỏ các thuộc tính khóa ngoại để tránh liên kết vòng
                var _sanPham1 = sanPham1
                .Select(sp => new SanPham
                {
                    MaSanPham = sp.MaSanPham,
                    TenSanPham = sp.TenSanPham,
                    DonGiaBanNhoNhat = sp.DonGiaBanNhoNhat,
                    DonGiaBanLonNhat = sp.DonGiaBanLonNhat,
                    TrangThai = sp.TrangThai,
                    MoTaNgan = sp.MoTaNgan,
                    AnhDaiDien = sp.AnhDaiDien,
                    NoiBat = sp.NoiBat,
                    MaPhanLoaiPhu = sp.MaPhanLoaiPhu,
                    MaPhanLoai = sp.MaPhanLoai,
                    GiaNhap = sp.GiaNhap
                }).ToList();

                return Json(new { success = true, sanPham = _sanPham1 });
            }

            // trường hợp người dùng chọn các phân loại còn lại
            var sanPham = db.SanPhams
                .Where(sp => sp.PhanLoaiPhu.TenPhanLoaiPhu == phanLoai).ToList();

            // bỏ các thuộc tính khóa ngoại để tránh liên kết vòng
            var _sanPham = sanPham
                .Select(sp => new SanPham
                {
                    MaSanPham = sp.MaSanPham,
                    TenSanPham = sp.TenSanPham,
                    DonGiaBanNhoNhat = sp.DonGiaBanNhoNhat,
                    DonGiaBanLonNhat = sp.DonGiaBanLonNhat,
                    TrangThai = sp.TrangThai,
                    MoTaNgan = sp.MoTaNgan,
                    AnhDaiDien = sp.AnhDaiDien,
                    NoiBat = sp.NoiBat,
                    MaPhanLoaiPhu = sp.MaPhanLoaiPhu,
                    MaPhanLoai = sp.MaPhanLoai,
                    GiaNhap = sp.GiaNhap
                }).ToList();

            return Json(new { success = true, sanPham = _sanPham });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}