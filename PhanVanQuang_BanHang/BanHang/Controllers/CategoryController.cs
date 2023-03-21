using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanHang.Context;

namespace BanHang.Controllers
{
    public class CategoryController : Controller
    {

        webbanhangEntities objwebbanhangEntities = new webbanhangEntities();
        // GET: Category
        public ActionResult Category()
        {
            var lstCategory = objwebbanhangEntities.Categories.ToList();
            return View(lstCategory);
        }
    }
}