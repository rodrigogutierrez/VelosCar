using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VelosCar.Models;

namespace VelosCar.Controllers
{
    public class CombustibleController : Controller
    {
        //
        // GET: /Combustible/
        VelosCarContext _db = new VelosCarContext();

        public ActionResult Index()
        {
            var combustible = _db.Combustibles.ToList();
            return View(combustible);
        }

        public ActionResult Crear(Combustible c)
        {
            if (ModelState.IsValid)
            {
                _db.Combustibles.Add(c);
                _db.SaveChanges();

                return RedirectToRoute("combustibles");
            }

            return RedirectToRoute("registrar_combustible");
        }

        public ActionResult Editar(int id)
        {
            Combustible c = _db.Combustibles.Find(id);
            return View(c);
        }

        public ActionResult Actualizar(int id, Combustible c)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(c).State = System.Data.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToRoute("ver_combustible", new { id = id });
            }

            return RedirectToRoute("editar_combustible", new { id = id });
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Ver(int id)
        {
            Combustible c = _db.Combustibles.Find(id);
            return View(c);
        }
    }
}
