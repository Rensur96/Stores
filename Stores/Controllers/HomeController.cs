using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stores.Models;
using Stores.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _contex;
    
        public HomeController( AppDbContext context)
        {
            _contex = context;

        }

        public IActionResult Index()
        {
            IEnumerable<Store> liststores = _contex.Store;
            return View(liststores);
        }

        public IActionResult AddStore()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStore(Store model)
        {
            if (ModelState.IsValid)
            {
                _contex.Store.Add(model);
                _contex.SaveChanges();
                string nombre = model.Nombre;
                TempData["mensaje"] = "Store '" + nombre + "' agregada correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Get store
            var store = _contex.Store.Find(id);
            if (store == null)
            {
                return NotFound();
            }
            return View(store);
        }

        [HttpPost]
        public IActionResult Update(Store store)
        {
            if (ModelState.IsValid)
            {
                _contex.Store.Update(store);
                _contex.SaveChanges();
                string nombre = store.Nombre;
                TempData["mensaje"] = "Store '" + nombre + "' actualizada correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }
        // get Delete
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Get store
            var store = _contex.Store.Find(id);
            if (store == null)
            {
                return NotFound();
            }
            return View(store);
        }
        //post DeleteStore
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStore(int? id)
        {
            var store = _contex.Store.Find(id);
            string nombre = store.Nombre.ToString();
            if (store == null)
            {
                return NotFound();
            }

            _contex.Store.Remove(store);
            _contex.SaveChanges();

            TempData["mensaje"] = "Store '" + nombre + "' eliminada correctamente";
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
