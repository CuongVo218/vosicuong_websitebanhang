using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitebanhang.Context;

namespace websitebanhang.Controllers
{
    public class CategoryController : Controller
    {
        dbWebBanHangEntities objdbWebBanHangEntities = new dbWebBanHangEntities();
        // GET: Category
        public ActionResult Index()
        {
            var lstCategory = objdbWebBanHangEntities.Categories.ToList();
            return View(lstCategory);
        }
        public ActionResult ProductCategory(int id)
        {
            var listProduct = objdbWebBanHangEntities.Products.Where(n => n.CategoryId == id).ToList();
            return View(listProduct);
        }
    }
}