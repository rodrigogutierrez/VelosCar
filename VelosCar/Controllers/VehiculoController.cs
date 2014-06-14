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
            ViewBag.indice = 1;
            var vehiculo = _db.Vehiculos.ToList();
            return View(vehiculo);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Crear(Vehiculo v)
        {
            if (ModelState.IsValid)
            {
                _db.Vehiculos.Add(v);
                _db.SaveChanges();

                return RedirectToRoute("vehiculos");
            }
            return RedirectToRoute("registrar_vehiculo");
        }

        public ActionResult Editar(int id)
        {
            Vehiculo v = _db.Vehiculos.Find(id);
            return View();
        }

        public ActionResult Actualizar(int id, Vehiculo v)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(v).State = System.Data.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToRoute("ver_vehiculo", new { id = id });
            }

            return RedirectToRoute("editar_vehiculo", new { id = id });
        }

        public ActionResult Ver(int id)
        {
            Vehiculo v = _db.Vehiculos.Find(id);
            return View(v);
        }
    }
}
