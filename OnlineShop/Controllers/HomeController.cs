﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult Produce()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}