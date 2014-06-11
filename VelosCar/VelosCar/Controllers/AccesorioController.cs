using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VelosCar.Models;

namespace VelosCar.Controllers
{
    public class AccesorioController : Controller
    {
        //
        // GET: /Accesorio/
        VelosCarContext _db = new VelosCarContext();

        public ActionResult Index()
        {
            var a = _db.Accesorios.ToList();
            return View(a);
        }

        public ActionResult Crear(Accesorio a)
        {
            if (ModelState.IsValid)
            {
                _db.Accesorios.Add(a);
                _db.SaveChanges();

                return RedirectToRoute("accesorios");
            }

            return RedirectToRoute("registrar_accesorio");
        }

        public ActionResult Editar(int id)
        {
            Accesorio a = _db.Accesorios.Find(id);
            return View(a);
        }

        public ActionResult Actualizar(int id, Accesorio a)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(a).State = System.Data.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToRoute("ver_accesorio", new { id = id });
            }

            return RedirectToRoute("editar_accesorio", new { id = id });
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Ver(int id)
        {
            var a = _db.Accesorios.ToList();
            return View(a);
        }

    }
}
