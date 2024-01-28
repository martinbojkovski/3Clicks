using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using ТриКлика.Models;

namespace ТриКлика.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Products = db.Products.ToList();
            return View();
        }
        [AllowAnonymous]
        public ActionResult Brands()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Refund()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Reclamation()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult FAQ()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}