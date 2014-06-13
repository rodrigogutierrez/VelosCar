using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VelosCar.Models;

namespace VelosCar.Controllers
{
    public class SucursalController : Controller
    {
        //
        // GET: /Sucursal/
        VelosCarContext _db = new VelosCarContext();

        public ActionResult Index()
        {
            var sucursal = _db.Sucursales.ToList();
            return View(sucursal);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Crear(Sucursal s)
        {
            if (ModelState.IsValid)
            {
                _db.Sucursales.Add(s);
                _db.SaveChanges();

                return RedirectToRoute("sucursales");
            }

            return RedirectToRoute("registrar_sucursal");
        }

        public ActionResult Editar(int id)
        {
            Sucursal s = _db.Sucursales.Find(id);
            return View(s);
        }

        public ActionResult Actualizar(int id, Sucursal s)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(s).State = System.Data.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToRoute("ver_sucursal", new { id = id });
            }

            return RedirectToRoute("editar_sucursal", new { id = id });
        }

        public ActionResult Ver(int id)
        {
            Sucursal s = _db.Sucursales.Find(id);
            return View(s);
        }

    }
}
