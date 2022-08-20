using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitebanhang.Context;

namespace websitebanhang.Controllers
{
    public class ProductController : Controller
    {
        dbWebBanHangEntities objdbWebBanHangEntities = new dbWebBanHangEntities();
        // GET: Product
        public ActionResult Detail(int id)
        {
            var objProduct = objdbWebBanHangEntities.Products.Where(n => n.Id == id).FirstOrDefault();
            return View(objProduct);
        }
    }
}