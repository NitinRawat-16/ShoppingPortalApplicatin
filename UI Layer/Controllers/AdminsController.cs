using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI_Layer.Controllers
{
    public class AdminsController : Controller
    {
        // GET: Admin
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult ProductList()
        {
            return View();
        }

        public ActionResult ProductAlert()
        {
            return View();
        }

        public ActionResult ProductConfirm()
        {
            return View();
        }

        public ActionResult TodayExpectedDelivery()
        {
            return View();
        }



    }
}