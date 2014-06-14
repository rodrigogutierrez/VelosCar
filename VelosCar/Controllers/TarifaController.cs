using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VelosCar.Models;

namespace VelosCar.Controllers
{
    public class TarifaController : Controller
    {
        //
        // GET: /Tarifa/
        VelosCarContext _db = new VelosCarContext();

        public ActionResult Index()
        {
            var tarifas = _db.Tarifas.ToList();
            return View(tarifas);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Crear(Tarifa t)
        {
            if (ModelState.IsValid)
            {
                _db.Tarifas.Add(t);
                _db.SaveChanges();

                return RedirectToRoute("tarifas");
            }

            return RedirectToRoute("registrar_tarifas");
        }

        public ActionResult Editar(int id)
        {
            Tarifa t = _db.Tarifas.Find(id);
            return View(t);
        }

        public ActionResult Actualizar(int id, Tarifa t)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(t).State = System.Data.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToRoute("ver_tarifa", new { id = id });
            }

            return RedirectToRoute("editar_tarifa", new { id = id });
        }

        public ActionResult Ver(int id)
        {
            Tarifa t = _db.Tarifas.Find(id);
            return View(t);
        }
    }
}
