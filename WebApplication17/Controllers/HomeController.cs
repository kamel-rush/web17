using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = ConfigurationManager.AppSettings["key1"];


            NorthwindEntities ORM = new NorthwindEntities();

            ViewBag.Customers = ORM.Customers.ToList();


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}