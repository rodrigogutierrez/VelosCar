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
            var usuario = _db.Usuarios.ToList();
            return View(usuario);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Crear(Usuario u)
        {
            if (ModelState.IsValid)
            {
                _db.Usuarios.Add(u);
                _db.SaveChanges();

                return RedirectToRoute("usuarios");
            }

            return RedirectToRoute("editar_usuario");
        }

        public ActionResult Editar(int id)
        {
            Usuario u = _db.Usuarios.Find(id);
            return View(u);
        }

        public ActionResult Actualizar(int id, Usuario u)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(u).State = System.Data.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToRoute("ver_usuario", new { id = id });
            }

            return RedirectToRoute("editar_usuario", new { id = id });
        }

        public ActionResult Ver(int id)
        {
            Usuario u = _db.Usuarios.Find(id);
            return View(u);
        }

    }
}
