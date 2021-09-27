﻿using InfinityStore.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfinityStore.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            return View(listadeProductos);
        }
    }
}