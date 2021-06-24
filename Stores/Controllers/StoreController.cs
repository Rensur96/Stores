using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    [Authorize(Roles = "administrador")]
    public class StoreController : Controller
    {
        private readonly AppDbContext _contex;
        private readonly UserManager<UsuarioApliacion> gestionUsuarios;
        private readonly SignInManager<UsuarioApliacion> gestionLogin;
        private readonly RoleManager<IdentityRole> gestionRoles;
        public StoreController(RoleManager<IdentityRole> gestionRoles ,AppDbContext context,UserManager<UsuarioApliacion> gestionUsuarios,SignInManager<UsuarioApliacion> gestionLogin)
        {
            this.gestionRoles = gestionRoles; 
            this.gestionUsuarios = gestionUsuarios;
            this.gestionLogin = gestionLogin;
            _contex = context;

        }

        [AllowAnonymous]
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
        [ValidateAntiForgeryToken]
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
