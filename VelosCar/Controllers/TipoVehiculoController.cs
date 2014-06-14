using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VelosCar.Models;

namespace VelosCar.Controllers
{
    public class TipoVehiculoController : Controller
    {
        //
        // GET: /TipoVehiculo/
        VelosCarContext _db = new VelosCarContext();

        public ActionResult Index()
        {
            var tipos = _db.TiposVehiculo.ToList();
            return View(tipos);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Crear(TipoVehiculo t)
        {
            if (ModelState.IsValid)
            {
                _db.TiposVehiculo.Add(t);
                _db.SaveChanges();

                return RedirectToRoute("tipos_vehiculo");
            }

            return RedirectToRoute("registrar_tipo_vehiculo");
        }

        public ActionResult Editar(int id)
        {
            TipoVehiculo t = _db.TiposVehiculo.Find(id);
            return View(t);
        }

        public ActionResult Actualizar(int id, TipoVehiculo t)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(t).State = System.Data.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToRoute("ver_tipo_vehiculo", new { id = id });
            }

            return RedirectToRoute("editar_tipo_vehiculo", new { id = id });
        }

        public ActionResult Ver(int id)
        {
            TipoVehiculo t = _db.TiposVehiculo.Find(id);
            return View(t);
        }
    }
}
