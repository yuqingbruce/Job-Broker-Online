using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Job_Broker_Online.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // Admin Page
        public ActionResult AdminPage()
        {
            return View();
        }

        // Employee Page
        public ActionResult EmployeePage()
        {
            return View();
        }

        // Student Page
        public ActionResult StudentPage()
        {
            return View();
        }
    }
}