﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuzzerBeater.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

     public ActionResult Register()
        {
            return View();
        }

        public ActionResult EmailVerification()
        {
            return View();
        }

        public ActionResult ConfirmEmail()
        {
            return View();
        }
    }
}
