using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   return View();
           
        }

        public ActionResult login()
        {
            return View();
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
        [HttpPost]
        public ActionResult LoginForm(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                return View("Index");
            }
            else
            {
                ModelState.AddModelError("", "Username or password is incorrect.");
            }
            return login() ;
        }
    }
}