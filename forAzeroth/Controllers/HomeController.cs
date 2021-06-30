using forAzeroth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
namespace forAzeroth.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Makisas Index page.";
            return View();
        }
        


        [HttpPost]
        public ViewResult Profile(MainModel apply)
        {
            return View("Application", apply);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Welcome to Makisas About us page.";

            return View();
        }
       
        public ActionResult Contact()
        {
            ViewBag.Message = "Welcome to Makisas contact page.";

            return View();
        }
        public ActionResult ProfileForm()
        {
            return View();
        }
    }
}