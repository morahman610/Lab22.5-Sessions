using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab22._5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult Login (string fullName, string username, string color)
        {
            ViewBag.FullName = fullName;
            ViewBag.Username = username;
            ViewBag.Color = color;

            Session["fullName"] = fullName;
            Session["username"] = username;
            Session["Color"] = color;

            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Clear();

            return View();
        }
    }
}