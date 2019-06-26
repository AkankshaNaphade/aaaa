using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;

namespace EComWFE.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = (List<Product>)this.HttpContext.Application["products"];
            this.ViewData["products"] = products;
            return View();
        }

       
            return View(foundProduct);
        }
    }
}