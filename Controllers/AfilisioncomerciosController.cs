using Microsoft.AspNetCore.Mvc;
using Proyecto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto1.Controllers
{
    public class AfilisioncomerciosController : Controller
    {
        private readonly Order2GoContext _context;
        private AfiliacionComercio afiliacioncomercio;

        public AfilisioncomerciosController(Order2GoContext context)
        {

            _context = context;
        }

        public IActionResult Index()
        {

            IEnumerable<AfiliacionComercio> listAfiliacion = _context.AfiliacionComercios;
            return View(listAfiliacion);
        }


        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(AfiliacionComercio afiliacioncomercio)
        {
            if (ModelState.IsValid)
            {
                _context.AfiliacionComercios.Add(afiliacioncomercio);
                _context.SaveChanges();

                TempData["mensaje"] = "Comercio agregado correctamente";
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {

                return NotFound();
            }

            var comercio = _context.AfiliacionComercios.Find(id);

            if (comercio == null)
            {

                return NotFound();
            }
            return View(comercio);
        }
        [HttpPost]
        public IActionResult Edit(AfiliacionComercio afiliacioncomercio)
        {
            if (ModelState.IsValid)
            {
                _context.AfiliacionComercios.Update(afiliacioncomercio);
                _context.SaveChanges();

                TempData["mensaje"] = "Comercio actualizado correctamente";
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

            var comercio = _context.AfiliacionComercios.Find(id);

            if (comercio == null)
            {

                return NotFound();
            }
            return View(comercio);

        }



        // POST: PRODUCTOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var comercio = _context.AfiliacionComercios.Find(id);
            _context.AfiliacionComercios.Remove(comercio);
            _context.SaveChanges();

            TempData["mensaje"] = "Comercio eliminado correctamente";
            return RedirectToAction("Index");
        }
    }
}
