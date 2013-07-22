using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWeb.Models;

namespace DemoWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(string id)
        {
            var modelo = new ModeloDemo();
            //ViewBag.Usuario = id;
            modelo.Nombre = id;
            modelo.Apellido = "otro valor";
            return View(modelo);
        }

        public ActionResult Index2() {
            return View();
        }

        [HttpPost]
        public ActionResult Index2(ModeloDemo modelo) {
            if (!ModelState.IsValid) {
                return View(modelo);
            }

            return View("VistaConDatos", modelo);
        }

    }
}
