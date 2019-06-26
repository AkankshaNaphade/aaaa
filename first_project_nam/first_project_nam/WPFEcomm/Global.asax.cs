using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BOL;
using BLL1;
namespace WPFEcomm
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            List<Product> products = new List<Product>();
            products = ProductBLL.GetAll();
            this.Application["products"] = products;
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
