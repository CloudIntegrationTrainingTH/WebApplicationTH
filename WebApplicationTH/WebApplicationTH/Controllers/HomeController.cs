﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTH.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            for (Int32 i = 0; i < 500; i++)
            {
                string test = "1";
            }

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
    }
}