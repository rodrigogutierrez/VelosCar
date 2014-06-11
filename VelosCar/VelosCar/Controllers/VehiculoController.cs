using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VelosCar.Models;

namespace VelosCar.Controllers
{
    public class VehiculoController : Controller
    {
        //
        // GET: /Vehiculo/
        VelosCarContext _db = new VelosCarContext();

        public ActionResult Index()
        {
            var vehiculo = _db.Vehiculos.ToList();
            return View(vehiculo);
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
