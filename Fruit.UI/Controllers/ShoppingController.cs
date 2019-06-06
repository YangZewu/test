using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fruit.Model;
using Fruit.BLL;
namespace Fruit.UI.Controllers
{
    public class ShoppingController : Controller
    {
        private ShopServer shop = new ShopServer();
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Shop()
        {
            return View();
        }
        public JsonResult Getshop(int limit, int offset)
        {
            List<Shopping> articles = shop.GetListsByPage(offset, limit, (a) => true);
            int total = shop.GetCount((a) => true);
            return Json(new { total = total, rows = articles }, JsonRequestBehavior.AllowGet);
        }
    }
}