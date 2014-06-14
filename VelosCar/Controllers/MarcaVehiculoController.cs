using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VelosCar.Models;

namespace VelosCar.Controllers
{
    public class MarcaVehiculoController : Controller
    {
        //
        // GET: /MarcaVehiculo/
        VelosCarContext _db = new VelosCarContext();

        public ActionResult Index()
        {
            var marcas = _db.Marcas.ToList();
            return View(marcas);
        }

        public ActionResult Crear(Marca m)
        {
            if (ModelState.IsValid)
            {
                _db.Marcas.Add(m);
                _db.SaveChanges();

                return RedirectToRoute("marcas");
            }

            return RedirectToRoute("registrar_marca");
        }

        public ActionResult Editar(int id)
        {
            Marca m = _db.Marcas.Find(id);
            return View(m);
        }

        public ActionResult Actualizar(int id, Marca m)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(m).State = System.Data.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToRoute("ver_marca", new { id = id });
            }

            return RedirectToRoute("editar_marca", new { id = id });
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Ver(int id)
        {
            Marca m = _db.Marcas.Find(id);
            return View(m);
        }

    }
}
