using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var source = new Class1
            {
                Title = "標題",
                Body = "內容"
            };
            return View(source);
        }

        [ChildActionOnly]
        public ActionResult SubAction()
        {
            var source = new Class1
            {
                Title = "標題222",
                Body = "內容222"
            };
            return View(source);
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