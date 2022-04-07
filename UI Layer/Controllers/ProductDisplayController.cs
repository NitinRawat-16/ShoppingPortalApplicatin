using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BusinessLogic;

namespace UI_Layer.Controllers
{
    public class ProductDisplayController : Controller
    {
        private ProductBl prodBl;

        public ProductDisplayController()
        {
            prodBl = new ProductBl();
        }

        // GET: ProductDisplay
        public ActionResult Index()
        {
            var product = prodBl.GetAll();
            return View(product);
        }
    }
}