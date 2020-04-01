using AlquilerVJ.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlquilerVJ.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos();

            ViewBag.adminWebsiteUrl = 
                ConfigurationManager.AppSettings["adminWebsiteUrl"]; //Me permite leer el valor que esta en Web.Config de 
                                                                     //ext.Web y ConfigManager -me permite leer el appSettings

            return View(listadeProductos);
        }
    }
}