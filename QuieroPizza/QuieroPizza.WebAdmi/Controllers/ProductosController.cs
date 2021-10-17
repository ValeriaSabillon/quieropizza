using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.WebAdmi.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productoBL;
        public ProductosController()
        {
            _productoBL = new ProductosBL();
        }
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }
    }
}