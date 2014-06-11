using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VelosCar.Models;

namespace VelosCar.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/
        VelosCarContext _db = new VelosCarContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Editar()
        {
            return View();
        }

        public ActionResult Actualizar()
        {
            return View();
        }

        public ActionResult Ver()
        {
            return View();
        }

    }
}
