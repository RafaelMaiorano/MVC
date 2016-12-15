using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prueba.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
          //  Models.Mensaje msg = "Use the source Luke!!";
          string msg = "Use the source Luke!!";
          //  ViewData.Model = msg;
          return View(model:msg);
        }
    }
}