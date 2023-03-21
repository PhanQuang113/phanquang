using BanHang.Context;
using BanHang.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanHang.Controllers
{
    public class HomeController : Controller
    {

        webbanhangEntities objwebbanhangEntities = new webbanhangEntities();     
        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();

            objHomeModel.ListCategory= objwebbanhangEntities.Categories.ToList();
            objHomeModel.ListProduct= objwebbanhangEntities.Products.ToList();
            return View (objHomeModel);

            
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