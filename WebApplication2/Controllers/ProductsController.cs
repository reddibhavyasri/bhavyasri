using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DeleteProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Deleteproduct(int id)
        {
            return View();
        }
        public ActionResult SearchProduct(int id)
        {
            return Content("Tried to find the product id " + id);
        }
        public ActionResult AddProduct()
        {
            return RedirectToAction("Index");
        }
        public ActionResult GoToGoogle()
        {
            return Redirect("https://www.google.com");
        }
        public ActionResult GoToIndexPageofHomeController()
        {
            return RedirectToAction("Index","Home");
        }
    }
}