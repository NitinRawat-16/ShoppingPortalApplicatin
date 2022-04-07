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

        public ActionResult AddToCart(Product product)
        {
            if(Session["cart"]==null)
            {
                List<Product> li = new List<Product>();

                li.Add(product);

                Session["cart"] = li;

                ViewBag.cart = li.Count();

                Session["count"] = 1;
            }

            else
            {
                List<Product> li = (List<Product>)Session["cart"];

                li.Add(product);

                Session["cart"] = li;

                ViewBag.cart = li.Count();

                Session["count"] = Convert.ToInt32(Session["count"]) + 1;
            }

            return RedirectToAction("Index" , "ProductDisplay");
        }

        public ActionResult MyOrder()
        {
            var cartItem = (List<Product>)Session["cart"];
            return View();
        }
    }
}