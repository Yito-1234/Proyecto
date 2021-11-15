using Microsoft.AspNetCore.Mvc;
using Proyecto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto1.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Order2GoContext _context;
        private Usuario usuario;

        public UsuariosController(Order2GoContext context)
        {
            _context = context;

        }

     

        public IActionResult Index()
        {
            IEnumerable<Usuario> usuario = _context.Usuarios;
            return View(usuario);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {

                return NotFound();
            }

            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {

                return NotFound();
            }
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();

       
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {

                return NotFound();
            }

            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {

                return NotFound();
            }
            return View(usuario);

        }



        // POST: PRODUCTOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }





    }
}
