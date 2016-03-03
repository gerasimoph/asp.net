using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Photos()
        {
            return View();
        }
        public ActionResult Useful()
        {
            return View();
        }
        public ActionResult WhatFor()
        {
            return View();
        }
    }
}
