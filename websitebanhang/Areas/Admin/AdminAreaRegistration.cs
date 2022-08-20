using System.Web.Mvc;

namespace websitebanhang.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //Url Login
            context.MapRoute(
                "DangNhapQuanTri",
                "Admin/dang-nhap-quan-tri",
                new { Controller = "DashBoard", action = "Login", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );

            //Url Category
            context.MapRoute(
                "QuanLyCategory",
                "Admin/quan-ly-danh-muc",
                new { Controller = "Category", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThemCategory",
                "Admin/quan-ly-danh-muc/them",
                new { Controller = "Category", action = "Create", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "SuaCategory",
                "Admin/quan-ly-danh-muc/cap-nhat/{slug}",
                new { Controller = "Category", action = "Edit", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "XoaCategory",
                "Admin/thung-rac-danh-muc/xoa/{slug}",
                new { Controller = "Category", action = "Delete", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThungRacCategory",
                "Admin/thung-rac-danh-muc",
                new { Controller = "Category", action = "Trash", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ChiTietCategory",
                "Admin/quan-ly-danh-muc/chi-tiet/{slug}",
                new { Controller = "Category", action = "Details", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );

            //Url Product
            context.MapRoute(
                "QuanLyProduct",
                "Admin/quan-ly-san-pham",
                new { Controller = "Product", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThemProduct",
                "Admin/quan-ly-san-pham/them",
                new { Controller = "Product", action = "Create", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "SuaProduct",
                "Admin/quan-ly-san-pham/cap-nhat/{slug}",
                new { Controller = "Product", action = "Edit", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ChiTietProduct",
                "Admin/quan-ly-san-pham/chi-tiet/{slug}",
                new { Controller = "Product", action = "Details", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "XoaProduct",
                "Admin/thung-rac-san-pham/xoa/{slug}",
                new { Controller = "Product", action = "Delete", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThungRacProduct",
                "Admin/thung-rac-san-pham",
                new { Controller = "Product", action = "Trash", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );

            //Url Brand
            context.MapRoute(
                "QuanLyBrand",
                "Admin/quan-ly-thuong-hieu",
                new { Controller = "Brand", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThemBrand",
                "Admin/quan-ly-thuong-hieu/them",
                new { Controller = "Brand", action = "Create", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "SuaBrand",
                "Admin/quan-ly-thuong-hieu/cap-nhat/{slug}",
                new { Controller = "Brand", action = "Edit", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ChiTietBrand",
                "Admin/quan-ly-thuong-hieu/chi-tiet/{slug}",
                new { Controller = "Brand", action = "Details", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "XoaBrand",
                "Admin/thung-rac-thuong-hieu/xoa/{slug}",
                new { Controller = "Brand", action = "Delete", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThungRacBrand",
                "Admin/thung-rac-thuong-hieu",
                new { Controller = "Brand", action = "Trash", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );

            //Url Post
            context.MapRoute(
                "QuanLyPost",
                "Admin/quan-ly-bai-viet",
                new { Controller = "Post", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThemPost",
                "Admin/quan-ly-bai-viet/them",
                new { Controller = "Post", action = "Create", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "SuaPost",
                "Admin/quan-ly-bai-viet/cap-nhat/{slug}",
                new { Controller = "Post", action = "Edit", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ChiTietPost",
                "Admin/quan-ly-bai-viet/chi-tiet/{slug}",
                new { Controller = "Post", action = "Details", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "XoaPost",
                "Admin/thung-rac-bai-viet/xoa/{slug}",
                new { Controller = "Post", action = "Delete", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThungRacPost",
                "Admin/thung-rac-bai-viet",
                new { Controller = "Post", action = "Trash", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );

            //Url Topic
            context.MapRoute(
                "QuanLyTopic",
                "Admin/quan-ly-chu-de-bai-viet",
                new { Controller = "Topic", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThemTopic",
                "Admin/quan-ly-chu-de-bai-viet/them",
                new { Controller = "Topic", action = "Create", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "SuaTopic",
                "Admin/quan-ly-chu-de-bai-viet/cap-nhat/{slug}",
                new { Controller = "Topic", action = "Edit", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ChiTietTopic",
                "Admin/quan-ly-chu-de-bai-viet/chi-tiet/{slug}",
                new { Controller = "Topic", action = "Details", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "XoaTopic",
                "Admin/thung-rac-chu-de-bai-viet/xoa/{slug}",
                new { Controller = "Topic", action = "Delete", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThungRacTopic",
                "Admin/thung-rac-chu-de-bai-viet",
                new { Controller = "Topic", action = "Trash", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );

            //Url User
            context.MapRoute(
                "QuanLyUser",
                "Admin/quan-ly-thanh-vien",
                new { Controller = "User", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThanhVien",
                "Admin/tai-khoan/{slug}",
                new { Controller = "User", action = "MyAccount", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThemUser",
                "Admin/quan-ly-thanh-vien/them",
                new { Controller = "User", action = "Create", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "SuaUser",
                "Admin/quan-ly-thanh-vien/cap-nhat/{slug}",
                new { Controller = "User", action = "Edit", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ChiTietUser",
                "Admin/quan-ly-thanh-vien/chi-tiet/{slug}",
                new { Controller = "User", action = "Details", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "XoaUser",
                "Admin/thung-rac-thanh-vien/xoa/{slug}",
                new { Controller = "User", action = "Delete", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThungRacUser",
                "Admin/thung-rac-thanh-vien",
                new { Controller = "User", action = "Trash", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );

            //Url Order
            context.MapRoute(
                "QuanLyDonHang",
                "Admin/quan-ly-don-hang",
                new { Controller = "Order", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ChiTietDonHang",
                "Admin/quan-ly-don-hang/chi-tiet/{slug}",
                new { Controller = "Order", action = "Details", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );

            //Url Slider
            context.MapRoute(
                "QuanLySlider",
                "Admin/quan-ly-slider",
                new { Controller = "Slider", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThemSlider",
                "Admin/quan-ly-slider/them",
                new { Controller = "Slider", action = "Create", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "SuaSlider",
                "Admin/quan-ly-slider/cap-nhat/{slug}",
                new { Controller = "Slider", action = "Edit", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ChiTietSlider",
                "Admin/quan-ly-slider/chi-tiet/{slug}",
                new { Controller = "Slider", action = "Details", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "XoaSlider",
                "Admin/thung-rac-slider/xoa/{slug}",
                new { Controller = "Slider", action = "Delete", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThungRacSlider",
                "Admin/thung-rac-slider",
                new { Controller = "Slider", action = "Trash", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );

            //Url Menu
            context.MapRoute(
                "QuanLyMenu",
                "Admin/quan-ly-menu",
                new { Controller = "Menu", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "SuaMenu",
                "Admin/quan-ly-menu/cap-nhat/{slug}",
                new { Controller = "Menu", action = "Edit", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ChiTietMenu",
                "Admin/quan-ly-menu/chi-tiet/{slug}",
                new { Controller = "Menu", action = "Details", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "XoaMenu",
                "Admin/thung-rac-menu/xoa/{slug}",
                new { Controller = "Menu", action = "Delete", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "ThungRacMenu",
                "Admin/thung-rac-menu",
                new { Controller = "Menu", action = "Trash", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );


            //Url defaule
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { Controller = "Dashboard", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopDienThoai.Areas.Admin.Controllers" }
            );
        }
    }
}